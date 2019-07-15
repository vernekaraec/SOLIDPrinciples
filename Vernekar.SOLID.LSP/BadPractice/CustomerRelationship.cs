
namespace Vernekar.SOLID.LSP.BadPractice
{
    public class CustomerRelationship
    {
        public virtual string GetClubAccessDetails()
        {
            //Access Club Area
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }

        public virtual string GetResortAccessDetails()
        {
            //Acess Resort Area
            return "DateTime:ID:Area:TimeIn:TimeOut:AccessArea";
        }
    }
}
