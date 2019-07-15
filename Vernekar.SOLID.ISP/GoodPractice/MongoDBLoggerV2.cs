
namespace Vernekar.SOLID.ISP.GoodPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// MongoDBLoggerV2 : Has the Get and Add operation of Audit trail; This is used by new customer
    /// </summary>
    public class MongoDBLoggerV2 : IDatabaseLogManagerV2, IDatabaseLogManager
    {
        public List<string> Get(string LogType)
        {
            // Read log from DB
            return new List<string>();
        }

        public void Add(string message, string LogType)
        {
            // Write in DB
        }
    }
}
