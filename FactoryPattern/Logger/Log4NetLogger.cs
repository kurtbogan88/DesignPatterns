using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Logger
{
    public class Log4NetLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Log wiht Log4Net");
        }
    }
}
