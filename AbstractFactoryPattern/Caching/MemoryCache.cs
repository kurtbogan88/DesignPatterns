using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Caching
{
    public class MemoryCache : Caching
    {
        public override void WriteCache()
        {
            Console.WriteLine("Memory Log Cache");
        }
    }
}
