
namespace Vernekar.SOLID.LSP.BadPractice
{
    public class CustomerRelationship
    {
        public virtual string GetClubAccessDetails(string customerId)
        {
            //Access Club Area
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }

        public virtual string GetResortAccessDetails(string customerId)
        {
            //Acess Resort Area
            return "DateTime:ID:Area:TimeIn:TimeOut:Accessories";
        }
    }
}
