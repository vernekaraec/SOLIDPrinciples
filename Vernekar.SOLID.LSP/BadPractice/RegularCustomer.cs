
namespace Vernekar.SOLID.LSP.BadPractice
{
    using System;

    /// <summary>
    /// This class fit for SRP and OCP, Here it get violates with LSP for 'GetResortAccessDetails' when i have access with base type 'CustomerRelationship'
    /// </summary>
    public class RegularCustomer : CustomerRelationship
    {
        public override string GetClubAccessDetails()
        {
            //Access Club Area
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }

        public override string GetResortAccessDetails()
        {
            //NO Access Resort Area
            throw new NotImplementedException();
        }
    }
}
