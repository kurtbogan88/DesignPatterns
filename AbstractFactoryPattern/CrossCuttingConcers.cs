using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class CrossCuttingConcers
    {
        public abstract Caching.Caching GetCaching();
        public abstract Logger.Logger GetLogger();
    }
}
