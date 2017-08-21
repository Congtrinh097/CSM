using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM.Common
{
    public class DateTimeHelper
    {
        public static DateTime GetDateTimeNow()
        {
            return DateTime.UtcNow;
        }
    }
}
