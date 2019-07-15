
namespace Vernekar.SOLID.LSP.GoodPractice
{
    public class PremiumCustomer : IClub, IResort
    {
        public string GetClubAccessDetails()
        {
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }

        public string GetResortAccessDetails()
        {
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }
    }
}
