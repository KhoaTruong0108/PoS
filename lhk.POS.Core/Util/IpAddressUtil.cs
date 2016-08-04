using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using lhk.POS.Core.Util;

namespace Utility
{
    public class IpAddressUtil
    {
        public static IPAddress GetExternalAddress(string urlRequest)
        {
            try
            {
                var html = new WebClient().DownloadString(urlRequest);

                var ipStart = html.IndexOf(": ", StringComparison.OrdinalIgnoreCase) + 2;
                return IPAddress.Parse(html.Substring(ipStart, html.IndexOf("</", ipStart, StringComparison.OrdinalIgnoreCase) - ipStart));
            }
            catch (Exception exc)
            {
                AppLogger.logError("IpAddressUtil", exc);
                return null;
            }
        }
    }

}
