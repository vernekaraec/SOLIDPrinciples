using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SOLID.ISP
{
    /// <summary>
    /// I = Interface Segregation Principle (ISP)
    /// It states "that clients should not be forced to implement interfaces they don't use. 
    /// Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one sub module."
    /// 
    /// We can illustrate with 'Logger' class for 'MongoDBLogger' class and 'TextLogger' class
    /// 'MongoDBLogger' have Read(IReadLogger) and Write(IWriteLogger)'
    /// 'TextLogger' have only Write(IWriteLogger)
    /// Have a two interface 'IWriteLogger' and 'IReadLogger'
    /// IWriteLogger -> has Write()
    /// IReadLogger -> has Read()
    /// 
    /// Now 'MongoDBLogger' owns with 'Read' and 'Write'
    /// Now 'TextLogger' owns with 'Read' 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
