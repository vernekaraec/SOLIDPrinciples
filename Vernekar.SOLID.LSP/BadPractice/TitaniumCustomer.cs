
namespace Vernekar.SOLID.LSP.BadPractice
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class fit for SRP and OCP, Here it get violates with LSP for 'GetResortAccessDetails' when i have access with base type 'CustomerRelationship'
    /// </summary>
    public class TitaniumCustomer : CustomerRelationship
    {
        public override List<string> GetClubAccessDetails()
        {
            //Access Club Area
            return new List<string>() { "CArea1", "CArea2", "CArea3", "CArea4", "CArea5" };
        }

        public override List<string> GetResortAccessDetails()
        {
            throw new NotImplementedException();
        }
    }
}
