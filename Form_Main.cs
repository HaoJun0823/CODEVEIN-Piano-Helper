using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CODEVEINPianoHelper
{
    public partial class Form_Main : Form
    {

        private System.Timers.Timer MessageTimer;
        public Form_Main()
        {
            InitializeComponent();
            StartMessageTimer();
            PianoHelper.Initialization();


            foreach (var i in Global.PianoKeyDictionary)
            {
                Button btn = ((PianoKey)i.Value).FormButton;
                Global.PushMessage(LogLevel.INFO, String.Format("Add button {0} to form.", btn.Text));
                this.FlowLayoutPanel_ButtonGroup.Controls.Add(btn);
            }




        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Global.PushMessage(LogLevel.INFO, String.Format("Initialize the virtual controller sensitivity to {0}.", Global.delay));
            NumericUpDown_Delay.Value = Global.delay;

        }


        private String GetMusicScoreString()
        {
            StringBuilder strBuild = new StringBuilder();


            for (int i = 0; i < RichTextBox_MusicScore.Lines.Count(); i++)
            {
                strBuild.Append(RichTextBox_MusicScore.Lines[i]);
            }


            Global.PushMessage(LogLevel.INFO, "Get the control script:"+strBuild.ToString());


            return strBuild.ToString();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {





            Global.ScriptCommandList = Script.Convert(GetMusicScoreString());
            Global.PushScriptCommandToLog();


            if (Global.MusicThread != null)
            {
                Global.MusicThread.Abort();
            }


            Global.MusicThread = new Thread(new ThreadStart(PianoHelper.PlayMusic));
            Global.MusicThread.Start();


        }


        private void StartMessageTimer()
        {
            Global.PushMessage(LogLevel.INFO, "Message Timer Starting...");

            MessageTimer = new System.Timers.Timer(1000);

            MessageTimer.Elapsed += new System.Timers.ElapsedEventHandler(delegate
            {

                MessageTimer.Stop();
                string message;
                while ((message = Global.PopMessage()) != null)
                {
                    this.Invoke(new MethodInvoker(delegate { RichTextBox_Log.Text += (message + '\n'); }), message);

                }
                MessageTimer.Start();

            });

            MessageTimer.AutoReset = true;
            MessageTimer.Start();

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            Global.StopMusicThread();

            MessageTimer.Stop();
            MessageTimer.Dispose();

            

        }

        private void RichTextBox_Log_TextChanged(object sender, EventArgs e)
        {
            RichTextBox_Log.SelectionStart = RichTextBox_Log.TextLength;
            RichTextBox_Log.SelectionLength = 0;
            RichTextBox_Log.ScrollToCaret();
        }

        private void NumericUpDown_Delay_ValueChanged(object sender, EventArgs e)
        {

            Global.delay = Decimal.ToInt32(NumericUpDown_Delay.Value);
            Global.PushMessage(LogLevel.INFO, String.Format("Set the virtual controller sensitivity to {0}.", Global.delay));
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {

            Global.StopMusicThread();
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, @"Welcome to use this tool! Please make sure you have installed ViGemBus. If not, please visit the following address to install the virtual driver:

https://github.com/ViGEm/ViGEmBus

When you hear a prompt similar to ""insert device"", the program will create a fake Xbox controller, which means this tool will have an effect! (Please ensure that you do not customize your controller buttons).
This tool is implemented through ViGemBus and virtualizes the Xbox 360 controller, so when you use it, please make sure that your little cutie stays in front of the piano(and is not sleeping)!
Then, you can press the button on the left to let your little partner hit the keys of the piano.If sometimes it doesn't work, please adjust the sensitivity (this option is used to simulate the reaction speed of the XBOX handle when it is pressed, the unit is Milliseconds, default 100).

About the script:
When you have written or shared the script yourself, you can paste it in the box on the right to experience automation.
""T"" means delay, followed by a number(milliseconds), which means that the next operation will wait for X seconds to execute.
The rest is the same as the button on the left, such as ""C2"", which is to simulate clicking the ""C2"" button on the left.
Please use "";"" to split each instruction.If there is an error in the instruction, the log will prompt, of course, the operation status will also be written in the log.
Please ensure that your script is continuous, without newlines and spaces.(Version 1.0.0.1: You can wrap! But keep the format as clean as possible.)

I wrote a paragraph in advance, you can try it!

I hope you can continue to support CODEVEIN created by Shift and Bandai Namco! I also hope we have more interesting new content in the future!
Enjoy it!

PS: I welcome you to share the score on this tool's Github website!

HaoJun0823", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();

        }
    }
}
