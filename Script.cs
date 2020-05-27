using Nefarius.ViGEm.Client.Targets.Xbox360;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEVEINPianoHelper
{
    class Script
    {

        public static IList<ScriptCommand> Convert(String script)
        {
            script = script.ToUpper();
            script = script.Replace((char)13, (char)0);
            script = script.Replace((char)10, (char)0);
            script = script.Replace((char)32, (char)0);

            Global.PushMessage(LogLevel.INFO, "Format the script:"+script);

            IList<ScriptCommand> list = new List<ScriptCommand>();

            script.Trim();
            String[] commandStr = script.Split(';');

            int number = 0;
            foreach (String i in commandStr)
            {

                if (i.Length <= 0)
                {
                    Global.PushMessage(LogLevel.WARNING, String.Format("Index {0} is a null command, pass!", number));
                    continue;
                }

                list.Add(ConvertCommand(i));
                number++;
            }



            return list;
        }

        public static ScriptCommand ConvertCommand(String str)
        {

            ScriptCommand script = null;

            if (str[0] == 'T')
            {
                String timeStr = str.Substring(1);
                int time = int.Parse(timeStr);
                script = new ScriptCommand(CommandType.Time, time);
            }
            else
            {
                String note = str.Substring(0);
                script = new ScriptCommand(CommandType.Note, note);
            }



            return script;
        }

    }



    class ScriptCommand
    {

        public CommandType Type { get; }
        public String Note { get; }
        public int Time { get; }

        public ScriptCommand(CommandType Type, String Note)
        {
            this.Type = Type;
            this.Note = Note;
        }

        public ScriptCommand(CommandType Type, int Time)
        {
            this.Type = Type;
            this.Time = Time;
        }

    }

    enum CommandType
    {
        Note, Time
    }

}
