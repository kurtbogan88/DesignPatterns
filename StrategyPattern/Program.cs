using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = new CustomerManager()
            {
                CreaditCalculateBase = new CalculateBefore2010()
            };

            customerManager.Save();
            customerManager.CreaditCalculateBase = new CalculateAfter2010();
            customerManager.Save();
            Console.ReadLine();

        }
    }

    abstract class CreaditCalculateBase
    {
        public abstract void CalculateSave();
    }

    class CalculateBefore2010 : CreaditCalculateBase
    {
        public override void CalculateSave()
        {
            Console.WriteLine("Calculate before 2010");
        }
    }

    class CalculateAfter2010 : CreaditCalculateBase
    {
        public override void CalculateSave()
        {
            Console.WriteLine("Calculate after 2010");
        }
    }

    class CustomerManager
    {
        public CreaditCalculateBase CreaditCalculateBase { get; set; }
        public void Save()
        {
            CreaditCalculateBase.CalculateSave();
        }
    }

}
