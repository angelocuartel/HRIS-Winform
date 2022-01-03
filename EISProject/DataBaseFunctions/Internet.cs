using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace EISProject.DataBaseFunctions
{
   public static class Internet
    {

        public static bool HasConnection()
        {
            return new Ping().Send("www.google.com.mx").Status == IPStatus.Success;
        }
    }
}
