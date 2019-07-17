
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
        /// <returns></returns>
        public void GetResortAccessCustomer(List<CustomerRelationship> customerRelationships)
        {
            foreach (var cust in customerRelationships)
            {
                cust.GetResortAccessDetails();
            }
        }

        /// <summary>
        /// Here customer strong type of IClub
        /// </summary>
        /// <param name="customerRelationships">Collection of all the customer</param>
        /// <returns></returns>
        public void GetClubAccessCustomer(List<IClub> customerRelationships)
        {
            foreach (var cust in customerRelationships)
            {
                cust.GetClubAccessDetails();
            }
        }
    }
}
