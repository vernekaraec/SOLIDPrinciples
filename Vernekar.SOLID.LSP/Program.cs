
using System.Collections.Generic;
using Vernekar.SOLID.LSP.BadPractice;

namespace Vernekar.SOLID.LSP
{
    /// <summary>
    /// L = Liskov Substitution Principle (LSP)
    /// It states that "you should be able to use any derived class instead of a parent class and have it behave 
    /// in the same manner without modification"
    /// Child class should not break parent class’s type definition and behavior.
    /// 
    /// We can illustrate with 'Customer' class as 'Gold Customer' class, 'Platinum Customer' class and 'Titanium Customer' class
    /// 'Gold Customer' have an access of 'club' and 'Resort'
    /// 'Platinum Customer' have an access of 'club' and 'Resort'
    /// 'Titanium Customer' have an access of only 'club'
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAccess customerAccess = new CustomerAccess();

            List<CustomerRelationship> crs = new List<CustomerRelationship>();
            crs.Add(new GoldCustomer() { });
            crs.Add(new PlatinumCustomer() { });
            crs.Add(new TitaniumCustomer() { });

            customerAccess.GetResortAccessCustomer(crs);
        }
    }
}
