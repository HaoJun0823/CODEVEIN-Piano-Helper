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
    class PianoHelper
    {
        //GAME 1.53
        private static readonly PianoKey[] DEFAULT_PIANO_KEY = new PianoKey[] {
        new PianoKey("C2",Xbox360Slider.LeftTrigger),
        new PianoKey("C3",Xbox360Button.LeftShoulder),
        new PianoKey("C4",Xbox360Button.Left),
        new PianoKey("C5",Xbox360Button.Up),
        new PianoKey("C6",Xbox360Button.Right),
        new PianoKey("C7",Xbox360Button.X),
        new PianoKey("D1",Xbox360Button.Y),
        new PianoKey("D2",Xbox360Button.A),
        new PianoKey("D3",Xbox360Button.RightShoulder),
        new PianoKey("D4",Xbox360Slider.RightTrigger),
        new PianoKey("D5",Xbox360Button.Down),
        new PianoKey("D6",Xbox360Button.LeftThumb),
        new PianoKey("D7",Xbox360Button.RightThumb),
        };



        public static void PlayMusic()
        {
            Global.PushMessage(LogLevel.WARNING, "Start Script!");
            foreach (ScriptCommand i in Global.ScriptCommandList)
            {

                if (i.Type == CommandType.Time)
                {
                    Global.PushMessage("Wait " + i.Time);
                    Thread.Sleep(i.Time);
                }
                else
                {
                    Global.PushMessage("Press " + i.Note);
                    try
                    {
                        Global.XboxController.Press(Global.PianoKeyDictionary[i.Note]);
                    }
                    catch
                    {
                        Global.PushMessage(LogLevel.ERROR, "Error Script Key:" + i.Note);
                        Global.PushMessage(LogLevel.FATAL, "FATAL SCRIPT RUNNING!!!!!");
                        Global.MusicThread.Abort();
                    }
                }
            }

            Global.PushMessage(LogLevel.WARNING, "End Script!");



        }

        public static void Initialization()
        {

            for (int i = 0; i < DEFAULT_PIANO_KEY.Length; i++)
            {
                DEFAULT_PIANO_KEY[i].FormButton = new Button();
                DEFAULT_PIANO_KEY[i].FormButton.Text = DEFAULT_PIANO_KEY[i].Note;
                DEFAULT_PIANO_KEY[i].FormButton.Click += new EventHandler(PianoKey.FormButton_Click);
                Global.PianoKeyDictionary.Add(DEFAULT_PIANO_KEY[i].Note, DEFAULT_PIANO_KEY[i]);
            }


        }




    }


    class PianoKey
    {
        public String Note { get; set; }
        public Xbox360Property XboxButton { get; set; }
        public Button FormButton { get; set; }


        public PianoKey(String note, Xbox360Property XboxButton, Button FormButton)
        {
            this.Note = note;
            this.XboxButton = XboxButton;
            this.FormButton = FormButton;
        }

        public PianoKey(String note, Xbox360Property XboxButton)
        {
            this.Note = note;
            this.XboxButton = XboxButton;
        }

        public static void FormButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Global.XboxController.Press(Global.PianoKeyDictionary[btn.Text]);




        }

    }

}
