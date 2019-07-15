
namespace Vernekar.SOLID.ISP.GoodPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// MongoDBLogger : Has the Add operation of Audit trail. This is used by many old customer
    /// </summary>
    public class MongoDBLogger : IDatabaseLogManager
    {
        public void Add(string message, string LogType)
        {
            // Write in DB
        }
    }
}
