
namespace Vernekar.SOLID.LSP
{
    /// <summary>
    /// L = Liskov Substitution Principle (LSP)
    /// It states that "you should be able to use any derived class instead of a parent class and have it behave 
    /// in the same manner without modification"
    /// Child class should not break parent class’s type definition and behavior.
    /// 
    /// We can illustrate with 'Customer' class as 'Premium Customer' class and 'Regular Customer' class
    /// 'Premium Customer' have an access of 'club' and 'Resort'
    /// 'Regular Customer' have an access of only 'club'
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
