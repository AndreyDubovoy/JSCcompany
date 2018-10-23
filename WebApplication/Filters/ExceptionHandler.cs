using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHolder.Filters
{
    public class ExceptionHandler : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext exceptionContext)
        {
            if (!exceptionContext.ExceptionHandled )
            {
                LogExeption.ExeptionHandler(exceptionContext.Exception);
                exceptionContext.Result = new RedirectResult(String.Format("/Home/ErrorView/?message={0}",exceptionContext.Exception.Message));
                exceptionContext.ExceptionHandled = true;
            }
        }
    }
}