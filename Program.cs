using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabajoPractico4
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
                        
            Market market = new Market();

            Application.Run(new LoginForm(market));            
        }
    }
}
