
using System.Collections.Generic;

namespace Vernekar.SOLID.ISP.BadPractice
{
    /// <summary>
    /// Consider the application needs logging(Adding logging details) the Audit trail in MongoDB.
    /// 
    /// After few months, client want's to have a new functionality for reading the Audit trail from MongoDB. We end with adding "Read" prototype :)
    /// 
    /// Now "IDatabaseLogManager" had Add and Get. This will satify the SRP, OCP and LSP and violates with ISP. Because all the existing customer will get impacted with the updates in the tool
    /// 
    /// </summary>
    public interface IDatabaseLogManager
    {
        void Add(string message, string LogType);

        // We add a Get protype as below :)
        // Bad practice to add Get in existing interface - This Get operation is need for new customer
        //List<string> Get(string LogType);
    }

}
