using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    abstract class ReportFactory
    {
        public abstract IReport getReport(string reportType);
    }
}
