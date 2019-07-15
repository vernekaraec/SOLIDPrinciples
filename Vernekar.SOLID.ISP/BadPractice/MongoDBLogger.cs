
namespace Vernekar.SOLID.ISP.BadPractice
{
    public class MongoDBLogger : IDatabaseLogManager
    {
        public void Add(string message, string LogType)
        {
            // Write in DB
        }
    }
}
