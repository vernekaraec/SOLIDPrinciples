
namespace Vernekar.SOLID.ISP.GoodPractice
{
    /// <summary>
    /// MongoDBLogger is now pure support only with Write operation
    /// </summary>
    public class TextLogger : ILoggerWrite
    {
        public void Write(string message, string LogType)
        {
            //Write in file
        }
    }
}
