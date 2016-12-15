using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputSpeedExamination
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool DEBUG = true;
            if (args.Length == 0 && !DEBUG)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "update.exe";
                    startInfo.Arguments = "";
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    throw;
                }
                return;
            }
            else if (DEBUG || args[0].ToString() == "updatedone")
            {
                ;
            }
            else
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            string g1 = Guid.NewGuid().ToString("N");
            Application.Run(new Form_Main());
        }
    }
}
