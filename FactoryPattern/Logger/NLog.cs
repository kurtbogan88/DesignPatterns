using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Logger
{
    public class NLog : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Log with NLog");
        }
    }
}
