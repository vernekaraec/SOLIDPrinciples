
namespace Vernekar.SOLID.ISP.BadPractice
{
    public class MongoDBLogger : ILoggerManager
    {
        public void Write(string message, string LogType)
        {
            // Write in DB
        }
    }
}
