using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
     sealed public class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }
        public void DisplayReportTitle()
        {
            Console.WriteLine($"Report Title: {ReportTitle}");
        }
    }
}
