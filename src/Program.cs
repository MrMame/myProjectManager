using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using myProjectManager.Views;

namespace myProjectManager
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

            // Start the Windows
            // -------------------------
            // Main Application Window. If Application is in Testmode, comment this out
            // Application.Run(new Form1());
            // ACtivate this to run the TestingForm first 
            Application.Run(new FormTesting());
        }
    }
}
