﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APA_Reference_App
{
   public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static MainScreen main = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new MainScreen();
            Application.Run(main);
        }

        public static MainScreen GetMain()
        {
            return main;
        }
    }
}
