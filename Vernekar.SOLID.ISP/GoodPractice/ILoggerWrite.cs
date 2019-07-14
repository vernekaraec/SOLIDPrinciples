
namespace Vernekar.SOLID.ISP.GoodPractice
{
    /// <summary>
    /// Here i have created 'Write' prototype as seperate interface and i can use for both 'MongoDB Logger' and 'Text logger'
    /// </summary>
    public interface ILoggerWrite
    {
        void Write(string message, string LogType);
    }
}
