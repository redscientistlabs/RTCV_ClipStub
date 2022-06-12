namespace ClipStub
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using RTCV.Common;
    using RTCV.CorruptCore;
    using RTCV.NetCore;
    using RTCV.NetCore.Commands;
    using RTCV.Vanguard;
    public static class VanguardImplementation
    {
        public static VanguardConnector connector;
        public static void StartClient()
        {
            try
            {
                ConsoleEx.WriteLine("Starting Vanguard Client");
                Thread.Sleep(500); //When starting in Multiple Startup Project, the first try will be uncessful since
                                   //the server takes a bit more time to start then the client.

                var spec = new NetCoreReceiver();
                spec.Attached = VanguardCore.attached;
                spec.MessageReceived += OnMessageReceived;

                connector = new VanguardConnector(spec);
            }
            catch (Exception ex)
            {
                if (VanguardCore.ShowErrorDialog(ex, true) == DialogResult.Abort)
                    throw new AbortEverythingException();
            }
        }

        public static void RestartClient()
        {
            connector?.Kill();
            connector = null;
            StartClient();
        }
        public static void UpdateDomains()
        {
            if (!VanguardCore.vanguardConnected)
            {
                return;
            }
            try
            {
                PartialSpec gameDone = new PartialSpec("VanguardSpec");
                gameDone[VSPEC.SYSTEMPREFIX] = "Clipussi";
                gameDone[VSPEC.SYSTEMCORE] = "Clip Player";
                gameDone[VSPEC.MEMORYDOMAINS_BLACKLISTEDDOMAINS] = Array.Empty<string>();
                gameDone[VSPEC.MEMORYDOMAINS_INTERFACES] = GetInterfaces();
                gameDone[VSPEC.CORE_DISKBASED] = false;
                AllSpec.VanguardSpec.Update(gameDone);

                //This is local. If the domains changed it propgates over netcore
                LocalNetCoreRouter.Route(RTCV.NetCore.Endpoints.CorruptCore, RTCV.NetCore.Commands.Remote.EventDomainsUpdated, true, true);

                //Asks RTC to restrict any features unsupported by the stub
                LocalNetCoreRouter.Route(RTCV.NetCore.Endpoints.CorruptCore, RTCV.NetCore.Commands.Remote.EventRestrictFeatures, true, true);

            }
            catch (Exception ex)
            {
                if (VanguardCore.ShowErrorDialog(ex) == DialogResult.Abort)
                {
                    throw new RTCV.NetCore.AbortEverythingException();
                }
            }
        }

        public static MemoryDomainProxy[] GetInterfaces()
        {
            return new MemoryDomainProxy[] { new MemoryDomainProxy(new DummyMemoryDomain()) };
        }

        private static void OnMessageReceived(object sender, NetCoreEventArgs e)
        {
            try
            {
                // This is where you implement interaction.
                // Warning: Any error thrown in here will be caught by NetCore and handled by being displayed in the console.

                var message = e.message;
                var simpleMessage = message as NetCoreSimpleMessage;
                var advancedMessage = message as NetCoreAdvancedMessage;

                ConsoleEx.WriteLine(message.Type);
                switch (message.Type) //Handle received messages here
                {
                    case RTCV.NetCore.Commands.Remote.AllSpecSent:
                        {
                            //We still need to set the emulator's path
                            AllSpec.VanguardSpec.Update(VSPEC.EMUDIR, VanguardCore.emuDir);
                            SyncObjectSingleton.FormExecute(() =>
                            {
                                UpdateDomains();
                            });
                        }
                        break;
                    case RTCV.NetCore.Commands.Basic.SaveSavestate:
                        e.setReturnValue(VanguardCore.OpenRomFilename);
                        break;

                    case RTCV.NetCore.Commands.Basic.LoadSavestate:
                        e.setReturnValue(true);
                        break;
                    case Remote.LoadROM:
                        {
                            SyncObjectSingleton.FormExecute(() =>
                            {
                                VideoPlayer.ClipPath = (string)((NetCoreAdvancedMessage)e.message).objectValue;
                                VideoPlayer.ClipStream = new FileStream(VideoPlayer.ClipPath, FileMode.Open, FileAccess.Read);
                                VideoPlayer.StreamInput = new LibVLCSharp.Shared.StreamMediaInput(VideoPlayer.ClipStream);
                                VideoPlayer.LoadedMedia = new LibVLCSharp.Shared.Media(StubForm.LibVLCInstance, VideoPlayer.StreamInput);
                                VanguardCore.OpenRomFilename = VideoPlayer.ClipPath;
                                StubForm.Player.PlayVLC();
                            });
                        } break;
                    case RTCV.NetCore.Commands.Remote.PreCorruptAction:



                        break;

                    case RTCV.NetCore.Commands.Remote.PostCorruptAction:
                        break;

                    case RTCV.NetCore.Commands.Remote.CloseGame:
                        break;

                    case RTCV.NetCore.Commands.Remote.DomainGetDomains:
                        SyncObjectSingleton.FormExecute(() =>
                        {
                            UpdateDomains();
                        });
                        break;

                    case RTCV.NetCore.Commands.Remote.DomainRefreshDomains:
                        SyncObjectSingleton.FormExecute(() => {
                            UpdateDomains();
                        });
                        break;

                    case RTCV.NetCore.Commands.Remote.EventEmuMainFormClose:
                        SyncObjectSingleton.FormExecute(() =>
                        {
                            Environment.Exit(0);
                        });
                        break;
                    case RTCV.NetCore.Commands.Remote.IsNormalAdvance:
                        e.setReturnValue(true);
                        break;

                    case RTCV.NetCore.Commands.Remote.EventCloseEmulator:
                        Environment.Exit(-1);
                        break;
                }
            }
            catch (Exception ex)
            {
                if (VanguardCore.ShowErrorDialog(ex, true) == DialogResult.Abort)
                    throw new AbortEverythingException();
            }
        }
    }
}