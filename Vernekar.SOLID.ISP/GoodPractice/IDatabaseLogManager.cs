
namespace Vernekar.SOLID.ISP.GoodPractice
{
    /// <summary>
    /// Here i have created 'Add' prototype to add the logging(Audit trail)
    /// </summary>
    public interface IDatabaseLogManager
    {
        void Add(string message, string LogType);
    }
}
