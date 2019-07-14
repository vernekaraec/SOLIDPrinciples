
namespace Vernekar.SOLID.DIP.GoodPractice
{
    /// <summary>
    /// Here this will have a loose coupling and no dependence of high level of class with low level of class
    /// Hence it is used as Constructor Injection and Higher module don't know about lower module like SMS, Email and Whatsapp
    /// 
    /// There are different types of injection like - Constructor injection, Property injection and Method injection
    /// </summary>
    public class Notification
    {
        private IMessaging _messaging;
        public Notification(IMessaging messaging)
        {
            _messaging = messaging;
        }

        public void Notify()
        {
            _messaging.SendMessage();
        }
    }
}
