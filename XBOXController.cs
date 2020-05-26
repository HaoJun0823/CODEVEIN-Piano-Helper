using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEVEINPianoHelper
{


    //See:https://forums.vigem.org/topic/350/creating-a-vigem-feeder-application-c-step-by-step
    class XboxController
    {

        private ViGEmClient client;
        public IXbox360Controller controller { get; set; }
        
        public XboxController()
        {

            try
            {
                client = new ViGEmClient();
                Global.PushMessage(LogLevel.INFO,"Create ViGEmClient...");
                controller = client.CreateXbox360Controller();
                Global.PushMessage(LogLevel.INFO,"Create vitrual Xbox360 Controller...");
                controller.Connect();
                Global.PushMessage(LogLevel.INFO,"Connect vitrual Xbox360 Controller...");
            }
            catch (Exception e)
            {
                MessageBox.Show(Global.MainForm, String.Format("You must install ViGemBus to use this tool:\n\n{0}\n\nOr this tool cannot create a vitrual xbox controller by ViGemBus.\nPlease try again or report this problems:\n\n{1}\n\nThis program will be close...\n\n{2}", "https://github.com/ViGEm/ViGEmBus", "https://github.com/HaoJun0823/CODEVEIN-Piano-Helper",e.Message), "Error! Unable to initialize device!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            
        }

        public void Press(PianoKey key)
        {

            if(key == null)
            {
                Global.PushMessage(LogLevel.ERROR,"Error Key!");
                return;
            }


            Global.PushMessage(key.Note);
            if(key.XboxButton is Xbox360Button)
            {
                new Thread(new ThreadStart(delegate
                {
                    controller.SetButtonState((Xbox360Button)key.XboxButton, true);
                    Thread.Sleep(Global.delay);
                    controller.SetButtonState((Xbox360Button)key.XboxButton, false);

                })).Start();
                
                
                
            }
            else if(key.XboxButton is Xbox360Slider)
            {
                new Thread(new ThreadStart(delegate
                {   
                    controller.SetSliderValue((Xbox360Slider)key.XboxButton, 255);
                    Thread.Sleep(Global.delay);
                    controller.SetSliderValue((Xbox360Slider)key.XboxButton, 0);

                })).Start();

                
            }
            else
            {

            }



        }

        
    }
}
