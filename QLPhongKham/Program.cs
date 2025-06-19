using QLPhongKham.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKham
{
    internal static class Program
    {
        public static string tenDN = "";
        public static int loaiDN = 0;
        public static bool reload = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
