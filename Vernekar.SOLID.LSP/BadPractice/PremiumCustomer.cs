
namespace Vernekar.SOLID.LSP.BadPractice
{
    /// <summary>
    /// This class fit for SRP and OCP 
    /// </summary>
    public class PremiumCustomer : CustomerRelationship
    {
        public override string GetClubAccessDetails(string customerId)
        {
            //Access Club Area
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }

        public override string GetResortAccessDetails(string customerId)
        {
            //Access Resort Area
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }
    }
}
