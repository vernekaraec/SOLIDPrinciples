
namespace Vernekar.SOLID.LSP.GoodPractice
{
    public class PremiumCustomer : IClub, IResort
    {
        public string GetClubAccessDetails(string customerId)
        {
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }

        public string GetResortAccessDetails(string customerId)
        {
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }
    }
}
