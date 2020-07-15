using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEVEINPianoHelper
{
    class Global
    {

        public static IDictionary<String, PianoKey> PianoKeyDictionary;
        public static IList<ScriptCommand> ScriptCommandList;
        public static Thread MusicThread;
        public static Form MainForm;
        public static XboxController XboxController;
        private static ConcurrentQueue<String> MessageQueue;
        public static int delay;

        public static void StopMusicThread()
        {

            if (Global.MusicThread != null && Global.MusicThread.IsAlive) { 

            Global.MusicThread.Abort();
            Global.PushMessage(LogLevel.WARNING, "The user stopped script!");

            }
        }

        public static void Initilization()
        {
            PianoKeyDictionary = new Dictionary<String, PianoKey>();
            ScriptCommandList = new List<ScriptCommand>(); MainForm = new Form_Main(); XboxController = new XboxController(); delay = 100;
        }

        public static void PushScriptCommandToLog()
        {
            int i = 0;
            StringBuilder strBuild = new StringBuilder("Run Command List:");
            foreach (ScriptCommand command in ScriptCommandList)
            {
                strBuild.Append(i);
                if (command.Type == CommandType.Time)
                {
                    strBuild.Append("-T");
                    strBuild.Append(command.Time);
                    strBuild.Append(";");
                }
                else
                {
                    strBuild.Append("-B");
                    strBuild.Append(command.Note);
                    strBuild.Append(";");

                }
                i++;
            }


            PushMessage(LogLevel.INFO, strBuild.ToString());
        }

        private static String GetLogLevelString(LogLevel level)
        {

            switch (level)
            {
                case LogLevel.TRACE:
                    return "[Trace]";
                case LogLevel.INFO:
                    return "[Info]";
                case LogLevel.WARNING:
                    return "[Warning]";
                case LogLevel.ERROR:
                    return "[Error]";
                case LogLevel.DEBUG:
                    return "[Debug]";
                case LogLevel.FATAL:
                    return "[Fatal]";
                default:
                    return "[Unknown]";
            }

        }

        public static void PushMessage(LogLevel level, String str)
        {
            if (MessageQueue == null)
            {
                MessageQueue = new ConcurrentQueue<String>();
            }


            MessageQueue.Enqueue(String.Format("[{0:G}]\t{1}\t{2}", DateTime.Now, GetLogLevelString(level), str));



        }

        public static void PushMessage(String str)
        {
            PushMessage(LogLevel.TRACE, str);
        }

        public static String PopMessage()
        {
            string message = null;
            MessageQueue.TryDequeue(out message);
            return message;
        }



    }




    enum LogLevel
    {
        INFO, TRACE, DEBUG, WARNING, ERROR, FATAL
    }
}
