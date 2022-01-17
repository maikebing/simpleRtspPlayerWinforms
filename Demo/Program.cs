using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var path = $"{AppContext.BaseDirectory}{System.IO.Path.DirectorySeparatorChar}{(Environment.Is64BitProcess ? "x64" : "x86")}{System.IO.Path.DirectorySeparatorChar }";
            //Environment.SetEnvironmentVariable("PATH", $"{Environment.GetEnvironmentVariable("PATH")};{path}", EnvironmentVariableTarget.Process);
            Application.Run(new frmMain());
        }
     
    }
}
