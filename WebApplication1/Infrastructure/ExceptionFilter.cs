using System.Web.Mvc;

namespace WebApplication1.Infrastructure
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception;
            LogHelper.Error(ex.Message,ex);

            filterContext.Result = new RedirectResult("~/Content/Error.html");
            filterContext.ExceptionHandled = true;
        }
    }
}