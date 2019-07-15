
namespace Vernekar.SOLID.ISP.GoodPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// Here i have created 'Get' prototype to reterive the logging details(Audit trail)
    /// </summary>
    public interface IDatabaseLogManagerV2
    {
        List<string> Get(string LogType);
    }
}
