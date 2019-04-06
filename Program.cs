using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mosaic
{
    static class Program
    {
        //Основная точка входа для приложения
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
