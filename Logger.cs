using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEVEINPianoHelper
{
    class Logger
    {

        enum Levels { Trace, Debug, Info, Warning, Error, Fatal };

        private string LogName
        {
            get;
            set;
        }

        private FileInfo LogFile
        {
            get;
            set;
        }

        public Logger(string name, string file)
        {

        }
    }
    }
