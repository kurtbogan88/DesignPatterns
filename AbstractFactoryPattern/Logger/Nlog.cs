using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Logger
{
    public class Nlog : Logger
    {
        public override void WriteLog()
        {
            Console.WriteLine("Nlog logging");
        }
    }
}
