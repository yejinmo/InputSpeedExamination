using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Update
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MessageBox.Show("");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foreach (var str in args)
                Console.WriteLine(str);
            Application.Run(new Form_Update(args));
        }
    }
}
