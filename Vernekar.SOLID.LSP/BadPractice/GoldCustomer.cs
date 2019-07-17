
using System.Collections.Generic;

namespace Vernekar.SOLID.LSP.BadPractice
{
    /// <summary>
    /// This class fit for SRP and OCP 
    /// </summary>
    public class GoldCustomer : CustomerRelationship
    {
        public override List<string> GetClubAccessDetails()
        {
            //Access Club Area
            return new List<string>() { "CArea1", "CArea2", "CArea3", "CArea4", "CArea5" };
        }

        public override List<string> GetResortAccessDetails()
        {
            //Access Resort Area
            return new List<string>() { "RArea1", "RArea2", "RArea3", "RArea4", "RArea5" };
        }
    }
}
