
namespace Vernekar.SOLID.ISP.GoodPractice
{
    using System.Collections.Generic;

    /// <summary>
    /// Here i have created 'Read' prototype as seperate interface and i can only use for 'MongoDB Logger'
    /// </summary>
    public interface ILoggerRead
    {
        List<string> Read(string LogType);
    }
}
