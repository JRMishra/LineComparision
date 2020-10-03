using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class LogDetails
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogUserInputError(Exception exp, string message)
        {
            logger.Error(exp, message);
        }

    }
}
