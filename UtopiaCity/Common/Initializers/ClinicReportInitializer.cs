using System;
using System.Linq;
using UtopiaCity.Common.Interfaces;
using UtopiaCity.Data;
using UtopiaCity.Models.Clinic;

namespace UtopiaCity.Common.Initializers
{
    public class ClinicReportInitializer : ISubDbInitializer
    {
        public void ClearSet(ApplicationDbContext context)
        {
            if (!context.ClinicReport.Any())
            {
                return;
            }

            context.RemoveRange(context.ClinicReport.ToList());
            context.SaveChanges();
        }

        public void InitializeSet(ApplicationDbContext context)
        {
            if (context.ClinicReport.Any())
            {
                return;
            }

            var report141 = new ClinicReport
            {
                Report = "Report 141",
                ReportTime = DateTime.Now
            };

            var report142 = new ClinicReport
            {
                Report = "Report 142",
                ReportTime = DateTime.Now
            };

            var report143 = new ClinicReport
            {
                Report = "Report 143",
                ReportTime = DateTime.Now
            };

            context.AddRange(report141, report142, report143);
            context.SaveChanges();
        }
    }
}
