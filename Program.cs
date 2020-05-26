using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CODEVEINPianoHelper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {


            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Run();
        }

        static void Run()
        {
            Global.Initilization();
            Application.Run(Global.MainForm);
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {

            Console.WriteLine("Try!");
            string resourceName = "CODEVEINPianoHelper." + new AssemblyName(args.Name).Name + ".dll";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }


    }
}
