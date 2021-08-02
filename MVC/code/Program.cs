using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garden.View;
using WindowsFormsApp1.Controller;

namespace Garden
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
            CVisitor controllerVisitor = new CVisitor();
            Application.Run(controllerVisitor.accessVisitorView());
        }
    }
}
