
namespace Vernekar.SOLID.LSP.BadPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// Let's check LSP is satisfying or not
    /// </summary>
    public class CustomerAccess
    {
        /// <summary>
        /// When client check for customer data of Resort Access, Titanium customer will not have an access of Resort and throws exception and violating the LSP
        /// How we can overcome this issue? 
        /// Here is the solution - Abstaction of Club and Resort area as Interface. We will see in 'GoodPractice' folder
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
        /// When client check for customer data of Resort Access, Titanium customer will have an access of Resort and no problem at here!
        /// </summary>
        /// <param name="customerRelationships">Collection of all the customer</param>
        /// <returns></returns>
        public void GetClubAccessCustomer(List<CustomerRelationship> customerRelationships)
        {
            foreach (var cust in customerRelationships)
            {
                cust.GetClubAccessDetails();
            }
        }
    }
}
