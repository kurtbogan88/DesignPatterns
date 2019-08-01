using FactoryPattern.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface ILoggerFactory
    {
        ILogger GetLogger();
    }
}
