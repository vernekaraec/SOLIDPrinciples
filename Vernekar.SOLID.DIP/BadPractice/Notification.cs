
namespace Vernekar.SOLID.DIP.BadPractice
{
    /// <summary>
    /// Done. It is perfect with  the Email notiifcation. But we have dependence of Messaging class.
    /// If we want to introduce any other like SMS then? We need to change the notification system also.
    /// And this is called tightly coupled. What can we do to make it loosely coupled?
    /// </summary>
    public class Notification
    {
        private Email _email = null;
        public Notification()
        {
            _email = new Email();
        }
        public void Notify()
        {
            _email.SendMessage();
        }
    }
}
