
namespace Vernekar.SOLID.ISP.BadPractice
{
    public class TextLogger : ILoggerManager
    {
        public void Write(string message, string LogType)
        {
            //Write in file
        }
    }
}
