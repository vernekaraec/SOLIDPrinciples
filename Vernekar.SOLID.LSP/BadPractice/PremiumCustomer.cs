
namespace Vernekar.SOLID.LSP.BadPractice
{
    /// <summary>
    /// This class fit for SRP and OCP 
    /// </summary>
    public class PremiumCustomer : CustomerRelationship
    {
        public override string GetClubAccessDetails()
        {
            //Access Club Area
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }

        public override string GetResortAccessDetails()
        {
            //Access Resort Area
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }
    }
}
