using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fa1 = new Factory1();
            var fa2 = new Factory2();

            fa1.GetCaching().WriteCache();
            fa1.GetLogger().WriteLog();

            fa2.GetCaching().WriteCache();
            fa2.GetLogger().WriteLog();

            Console.ReadLine();
        }
    }
}
