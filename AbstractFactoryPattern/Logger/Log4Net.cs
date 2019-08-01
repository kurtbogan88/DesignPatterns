using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Logger
{
    public class Log4Net : Logger
    {
        public override void WriteLog()
        {
            Console.WriteLine("Log4Net logging");
        }
    }
}
