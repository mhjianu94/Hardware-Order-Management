using System;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    static class App
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MainForm mainForm = new MainForm())
            {
                Application.Run(mainForm);
            }
        }
    }
}