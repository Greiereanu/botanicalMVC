using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Something happened to " + sender);
        }
    }
}
