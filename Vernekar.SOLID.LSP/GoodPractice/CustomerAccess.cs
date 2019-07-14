
namespace Vernekar.SOLID.LSP.GoodPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// Let's check LSP is satisfying or not. yes it is satisfying
    /// </summary>
    public class CustomerAccess
    {
        /// <summary>
        /// Here customer strong type of IResort. Here we don't have the issue and it is not violating the LSP
        /// Earier it was throwing an exception, now, it is abstracted with type of Access 
        /// </summary>
        /// <param name="customerRelationships">Collection of all the customer</param>
        /// <param name="customerId">Customer ID</param>
        /// <returns></returns>
        public string GetResortAccessCustomer(List<IResort> customerRelationships, string customerId)
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
        /// Here customer strong type of IClub
        /// </summary>
        /// <param name="customerRelationships">Collection of all the customer</param>
        /// <param name="customerId">Customer ID</param>
        /// <returns></returns>
        public string GetClubAccessCustomer(List<IClub> customerRelationships, string customerId)
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
