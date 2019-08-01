using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerFactory().GetLogger();
            logger.WriteLog();
            Console.ReadLine();
        }
    }
}
