
namespace Vernekar.SOLID.OCP.GoodPractice
{
    /// <summary>
    /// ‘ReportGenerationHelper’ class is taking one responsibilities, This is only meant for report generation
    /// Now client asked you to give a facility to generate the report in Excel and this class will do for it.
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
        public virtual string GenerateReport(Customer customer)
        {
            string generatedPath = null;

            // Generation logic for Excel report file
            // ....
            // ....
            // ....

            generatedPath = @"%appdata%\Customer\Report.xls";

            return generatedPath;
        }
    }
}
