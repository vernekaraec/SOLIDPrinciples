
namespace Vernekar.SOLID.ISP.BadPractice
{
    /// <summary>
    /// Consider the application needs logging on DB and text file. We have implemanted the write for MongoDB and Text file and we have released the application.
    /// 
    /// After few months, client want's to have reading the log only from MongoDB. We end with adding "Read" prototype :)
    /// 
    /// Now "ILoggerManager" had Write and Read. This will satify the SRP, OCP and LSP and violates with ISP. Because "TextLogger"
    /// only needs Write operation and not Reading operation
    /// 
    /// </summary>
    public interface ILoggerManager
    {
        void Write(string message, string LogType);

        // We add a Read protype as below :)
        // Bad practice - This Read operation only need for MongoDB. Let's seperate it and defined in "Good Practice"
        // List<string> Read(string LogType);
    }

}
