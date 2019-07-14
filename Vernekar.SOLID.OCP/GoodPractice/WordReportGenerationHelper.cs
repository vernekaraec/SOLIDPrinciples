
namespace Vernekar.SOLID.OCP.GoodPractice
{
    /// <summary>
    /// ‘WordReportGenerationHelper’ class is taking one responsibilities, This is only meant for report generation
    /// Now client asked you to give a facility to generate the report in 'Word' and this class will do for it.
    /// </summary>
    public class WordReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(Customer customer)
        {
            string generatedPath = null;

            // Generation logic for Word report file
            // ....
            // ....
            // ....

            generatedPath = @"%appdata%\Customer\Report.docx";

            return generatedPath;
        }
    }
}
