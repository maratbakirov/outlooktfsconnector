using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTfsConnector.Code
{
    public class Utils
    {
        const string url = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=CKQHEAZRP6BSW&currency_code=AUD";
        public static void OpenDonateUrl()
        {
            Process.Start(url);
        }
    }
}
