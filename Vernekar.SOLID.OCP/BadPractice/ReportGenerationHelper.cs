
namespace Vernekar.SOLID.OCP.BadPractice
{
    /// <summary>
    /// ‘ReportGenerationHelper’ class is taking one responsibilities, This is only meant for report generation
    /// Now client asked you to give a facility to generate the report in Excel or any other reporting format. Now problem comes in enhancing the report support
    /// 
    /// Too much ‘If’ clauses are there and if we want to introduce another new report type like ‘Excel’, then you need to write another ‘if’. 
    /// This class should be open for extension but closed for modification. But how to do that!!
    /// 
    /// Okay, No worries. Every thing is possible... let's dive into an 'GoodPractice' example
    /// </summary>
    public class ReportGenerationHelper
    {
        public string ReportType { get; set; }

        /// <summary>
        /// Generate the report of the customer
        /// Generates the report of Excel, Word or PDF
        /// </summary>
        /// <param name="customer">Customer data</param>
        /// <returns>Generated file path</returns>
        public string GenerateReport(Customer customer)
        {
            string generatedPath = null;
            if (ReportType == "EXCEL")
            {
                // Generation logic for Excel report file
                // ....
                generatedPath = @"%appdata%\Customer\Report.xls";
            }
            else if (ReportType == "PDF")
            {
                // Generation logic for PDF report file
                // ....
                generatedPath = @"%appdata%\Customer\Report.pdf";
            }
            else if (ReportType == "WORD")
            {
                // Generation logic for Word report file
                // ....
                generatedPath = @"%appdata%\Customer\Report.docx";
            }
            return generatedPath;
        }
    }
}
