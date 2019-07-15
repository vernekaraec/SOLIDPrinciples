using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.SOLID.ISP.GoodPractice;

namespace Vernekar.SOLID.ISP
{
    /// <summary>
    /// I = Interface Segregation Principle (ISP)
    /// It states "that clients should not be forced to implement interfaces they don't use. 
    /// Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one sub module."
    /// 
    /// Let's consider. When client uses the application with customer login ID, the tool logs the data in DB as a Audit trail 
    /// We can illustrate with 'IDatabaseLogManager' interface.
    /// 'IDatabaseLogManager' has Add() signature. This will only allow to add Audit trail in DB 
    /// 
    /// Say 'CustomerAuditLogger' class is inherited from 'IDatabaseLogManager' and owns only Add() operation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //For old/Existing client
            IDatabaseLogManager databaseLogManager = new MongoDBLogger();
            databaseLogManager.Add("Message", "INFO");

            //For New client
            IDatabaseLogManagerV2 databaseLogManagerv2 = new MongoDBLoggerV2();
            var result = databaseLogManagerv2.Get("INFO");
        }
    }
}
