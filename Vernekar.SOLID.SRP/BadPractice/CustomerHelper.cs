
namespace Vernekar.SOLID.SRP.BadPractice
{
    /// <summary>
    /// ‘CustomerHelper’ class is taking 2 responsibilities, 
    /// one is to take responsibility of Customer database operation and another one is to generate Customer report. 
    /// Customer class should not take the report generation responsibility because suppose some days after your client 
    /// asked you to give a facility to generate the report in Excel or any other reporting format, 
    /// then this class will need to be changed and that is not good.
    /// 
    /// So according to SRP, one class should take one responsibility so we should write one different class for report generation, 
    /// so that any change in report generation should not affect the ‘CustomerHelper’ class.
    /// </summary>
    public class CustomerHelper
    {
        /// <summary>
        /// Insert the customer record in DB
        /// </summary>
        /// <param name="customer">Customer data</param>
        public void AddCustomer(Customer customer)
        {
            //Add customer into records/DB
        }

        /// <summary>
        /// Update the customer record in DB
        /// </summary>
        /// <param name="customer">Customer data</param>
        public void UpdateCustomer(Customer customer)
        {
            //Update customer into records/DB
        }

        /// <summary>
        /// Delete the customer record in DB
        /// </summary>
        /// <param name="id">Customer ID</param>
        public void DeleteCustomer(int id)
        {
            //Delete customer into records/DB
        }

        /// <summary>
        /// Get the customer record by IB from DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Customer data</returns>
        public Customer GetCustomer(int id)
        {
            //Reterive customer into records/DB
            return new Customer();
        }

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
