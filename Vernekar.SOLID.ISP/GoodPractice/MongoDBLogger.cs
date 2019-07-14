
namespace Vernekar.SOLID.ISP.GoodPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// MongoDBLogger is now pure support with Read and Write operation
    /// </summary>
    public class MongoDBLogger : ILoggerRead, ILoggerWrite
    {
        public List<string> Read(string LogType)
        {
            // Read log from DB
            return new List<string>();
        }

        public void Write(string message, string LogType)
        {
            // Write in DB
        }
    }
}
