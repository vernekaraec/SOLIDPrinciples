
namespace Vernekar.SOLID.OCP.GoodPractice
{
    /// <summary>
    /// ‘PDFReportGenerationHelper’ class is taking one responsibilities, This is only meant for report generation
    /// Now client asked you to give a facility to generate the report in PDF and this class will do for it.
    /// </summary>
    public class PDFReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(Customer customer)
        {
            string generatedPath = null;

            // Generation logic for PDF report file
            // ....
            // ....
            // ....

            generatedPath = @"%appdata%\Customer\Report.pdf";

            return generatedPath;
        }
    }
}
