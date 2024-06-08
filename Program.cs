﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Splane());
            //Application.Run(new SplashScreen());
            SplashScreen splashScreen = new SplashScreen();
            if(splashScreen.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new Login());
            }

        }
    }
}
