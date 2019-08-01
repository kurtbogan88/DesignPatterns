using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Logger;

namespace FactoryPattern
{
    public class LoggerFactory : ILoggerFactory
    {
        private static ILogger _logger;
        private static object _lock = new object();
        public   ILogger GetLogger()
        {
            return GetAsLogger();

        }
        private   ILogger GetAsLogger()
        {
            lock (_lock)
            {
                if(_logger==null)
                {
                    var type = System.Configuration.ConfigurationManager.AppSettings["LogType"].ToString();
                    if (type == "Log4Net")
                        _logger = new Log4NetLogger();
                    else
                        _logger = new NLog();
                }
            }

            return _logger;
        }


    }
}
