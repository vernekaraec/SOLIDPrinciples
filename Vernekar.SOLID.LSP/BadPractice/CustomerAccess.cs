
namespace Vernekar.SOLID.LSP.BadPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// Let's check LSP is satisfying or not
    /// </summary>
    public class CustomerAccess
    {
        /// <summary>
        /// When client check for customer data of Resort Access, Regular customer will not have an access of Resort and throws exception and violating the LSP
        /// How we can overcome this issue? 
        /// Here is the solution - Abstaction of Club and Resort area as Interface. We will see in 'GoodPractice' folder
        /// </summary>
        /// <param name="customerRelationships">Collection of all the customer</param>
        /// <param name="customerId">Customer ID</param>
        /// <returns></returns>
        public string GetResortAccessCustomer(List<CustomerRelationship> customerRelationships, string customerId)
        {
            string result = null;
            foreach (var cust in customerRelationships)
            {
                result = cust.GetResortAccessDetails(customerId);
                break;
            }
            return result;
        }

        /// <summary>
        /// When client check for customer data of Resort Access, Regular customer will have an access of Resort and no problem at here!
        /// </summary>
        /// <param name="customerRelationships">Collection of all the customer</param>
        /// <param name="customerId">Customer ID</param>
        /// <returns></returns>
        public string GetClubAccessCustomer(List<CustomerRelationship> customerRelationships, string customerId)
        {
            string result = null;
            foreach (var cust in customerRelationships)
            {
                result = cust.GetClubAccessDetails(customerId);
                break;
            }
            return result;
        }
    }
}
