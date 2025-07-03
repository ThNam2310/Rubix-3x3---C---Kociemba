using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualRubiksCube
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // kích hoạt giao diện window hiện tại
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainForm());
        }
    }
}
