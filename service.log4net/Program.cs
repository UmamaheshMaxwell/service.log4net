using log4net;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.log4net
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalContext.Properties["Application"] = "Log4Net application";

            ILog log = LogManager.GetLogger("myLog");
            log.Info("This is my first log message");
            log.Debug("This is a debug message");
            log.Info("This is an information message");
            log.Warn("This is a warning message");
            log.Error("This is an error message");
            log.Fatal("This is a fatal message");

            // *Format-methods 
            var name = "Umamaheswararao Meka";
            log.Info($"Hello from {name}");
            log.InfoFormat("Hello from {0}", name); // Same result as above

            // using log Method
            log.Logger.Log(new LoggingEvent(new LoggingEventData
            {
                Level = Level.Error,
                Message = "An error happened"
            }));
        }
    }
}
