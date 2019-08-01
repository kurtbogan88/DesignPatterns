using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var crediManager = new CrediManager();

            var aa = crediManager.Calculate();
            Console.Write(aa.ToString());
            
            var creaditManagerProxy = new CreaditManagerProxy();
            var asd = creaditManagerProxy.Calculate();
            Console.WriteLine(asd);

            var asr = creaditManagerProxy.Calculate();
            Console.WriteLine(asr);

            Console.ReadLine();
        }
    }

    abstract class CreditBase
    {
        public abstract int Calculate();
    }

    class CrediManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;

            for (int i = 1; i < 10; i++)
            {
                result *= i;
                Thread.Sleep(5000);
            }

            return result;
        }
    }

    class CreaditManagerProxy : CreditBase
    {
        public CrediManager crediManager = null;
        public int _price = 0;
        public override int Calculate()
        {
            if (crediManager == null)
            {
                crediManager = new CrediManager();
                _price = crediManager.Calculate();
            }
            return _price;
        }
    }
}
