using System;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

namespace TeenPatti.Server
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            //  This needs to be done only once.
            SetupTables();

            RouteTable.Routes.MapConnection("connection", "/teenpatti", typeof(TeenPattiConnection), new ConnectionConfiguration() { EnableCrossDomain = true });
        }

        private static void SetupTables()
        {
            throw new NotImplementedException();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}