
namespace Vernekar.SOLID.LSP.BadPractice
{
    using System;

    /// <summary>
    /// This class fit for SRP and OCP, Here it get violates with LSP for 'GetResortAccessDetails' when i have access with base type 'CustomerRelationship'
    /// </summary>
    public class RegularCustomer : CustomerRelationship
    {
        public override string GetClubAccessDetails(string customerId)
        {
            //Access Club Area
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }

        public override string GetResortAccessDetails(string customerId)
        {
            //NO Access Resort Area
            throw new NotImplementedException();
        }
    }
}
