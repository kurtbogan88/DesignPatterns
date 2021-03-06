﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Caching;
using AbstractFactoryPattern.Logger;

namespace AbstractFactoryPattern
{
    public class Factory1 : CrossCuttingConcers
    {
        public override Caching.Caching GetCaching()
        {
            return new Caching.MemoryCache();
        }

        public override Logger.Logger GetLogger()
        {
            return new Logger.Log4Net();
        }
    }
}
