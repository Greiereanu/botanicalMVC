using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class ConcreteReportFactory : ReportFactory
    {
        public override IReport getReport(string reportType)
        {
            switch(reportType)
            {
                case "CSV":
                    return new CSVReport();
                case "JSON":
                    return new JSONReport();
                default:
                    throw new ApplicationException(string.Format("Report '{0}' cannot be created", reportType));
            }
        }
    }
}
