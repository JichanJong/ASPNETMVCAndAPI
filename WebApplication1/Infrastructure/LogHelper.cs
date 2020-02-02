using System;
using System.IO;
using System.Web;
using log4net;

namespace WebApplication1.Infrastructure
{
    public class LogHelper
    {
        private static readonly ILog Logger = LogManager.GetLogger("FileLogger");

        static LogHelper()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(HttpContext.Current.Server.MapPath("~/log4net.config")));
        }

        public static void Error(string errMessage,Exception ex)
        {
            Logger.Error(errMessage,ex);
        }
    }
}