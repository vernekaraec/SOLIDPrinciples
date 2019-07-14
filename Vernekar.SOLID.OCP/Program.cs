
namespace Vernekar.SOLID.OCP
{
    /// <summary>
    /// O = Open closed principle (OCP)
    /// "Open for extension" means, we need to design our module/class in such a way that the new functionality can be added only when new requirements are generated. 
    /// "Closed for modification" means we have already developed a class and it has gone through unit testing. We should then not alter it until we find bugs.
    /// 
    /// Let's take an example of "Customer" and "Report generation" functionality. How we can apply for Report Generation.
    /// 'GoodPractice' folder - Describes the Open for supporting different formats of Reports by using dynamic polymorphism concepts
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
