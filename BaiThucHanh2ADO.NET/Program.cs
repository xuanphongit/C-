using System;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Presentation;

namespace BaiThucHanh2ADO.NET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCauHinh());
        }
    }
}
