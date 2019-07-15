
namespace Vernekar.SOLID.LSP.GoodPractice
{
    /// <summary>
    /// This class fit for SRP and OCP, Here it get violates with LSP for 'GetResortAccessDetails' when i have access with base type 'CustomerRelationship'
    /// </summary>
    public class RegularCustomer : IClub
    {
        public string GetClubAccessDetails()
        {
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }
    }
}
