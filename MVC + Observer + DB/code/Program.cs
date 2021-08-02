using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garden.View;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.View;

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
            CVisitor controllerVisitor = new CVisitor(4);
            Application.Run(controllerVisitor.accessVisitorView());

        }
    }
}
