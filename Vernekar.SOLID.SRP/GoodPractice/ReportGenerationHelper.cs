
namespace Vernekar.SOLID.SRP.GoodPractice
{
    /// <summary>
    /// ‘ReportGenerationHelper’ class is taking one responsibilities, This is only meant for report generation
    /// </summary>
    public class ReportGenerationHelper
    {
        /// <summary>
        /// Genrate the report of the customer
        /// </summary>
        /// <param name="customer">Customer data</param>
        /// <returns>Generated file path</returns>
        public string GenerateReport(Customer customer)
        {
            //Generates the report of Excel, Word or PDF
            return @"%appdata%\Customer\Report.pdf";
        }
    }
}
