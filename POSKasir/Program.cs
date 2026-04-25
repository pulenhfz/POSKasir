using System;
using System.Windows.Forms;

namespace POSKasir
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show("Error: " + e.Exception.Message + "\n\n" + e.Exception.StackTrace,
                    "Unhandled Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                MessageBox.Show("Fatal Error: " + e.ExceptionObject.ToString(),
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            try
            {
                Application.Run(new FormLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Startup Error:\n" + ex.Message + "\n\n" + ex.StackTrace,
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
