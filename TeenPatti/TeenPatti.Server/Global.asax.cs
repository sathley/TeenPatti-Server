using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

namespace TeenPatti.Server
{
    public class Global : HttpApplication 
    {
        void Application_Start(object sender, EventArgs e)
        {

            // Code that runs on application startup
            //RouteTable.Routes.MapConnection("connection", "/connection", typeof(Connection), new ConnectionConfiguration() { EnableCrossDomain = true });
            Console.WriteLine("App start");
            Console.ReadKey(true);
        }
    }
}
