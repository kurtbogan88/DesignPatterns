using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Caching
{
    public class RedisCache : Caching
    {
        public override void WriteCache()
        {
            Console.WriteLine("Redis Cache");
        }
    }
}
