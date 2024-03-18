using LMS.Domain.Extentions;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Error_Exceptions
{
    public class SystemExceptions : Exception
    {
        private readonly ILoggerManager _loggerManager;
        public SystemExceptions(ILoggerManager loggerManager , Exception ex) : base(String.Format("System Error "))
        {
            _loggerManager = loggerManager;
            _loggerManager.LogError("Exception : " + ex.Message);
            if(ex.InnerException != null )
                _loggerManager.LogError(message: "Inner Exeption :" + ex.InnerException.Message);

        }


    }
}
