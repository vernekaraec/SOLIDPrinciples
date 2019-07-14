
namespace Vernekar.SOLID.OCP.GoodPractice
{
    /// <summary>
    /// ‘CustomerHelper’ class is taking one responsibilities, 
    /// It takes responsibility of only Customer database operation now :)
    /// Customer class is not taking the report generation responsibility then this class will be good enough to change only for Customer.
    /// 
    /// So according to SRP, one class should take one responsibility so we have seprated the class for report generation, 
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
    }
}
