using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Observable
    {
        public event EventHandler actionHappened;

        public void Notify()
        {
            actionHappened?.Invoke(this, EventArgs.Empty);
        }
    }
}
