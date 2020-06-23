using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;


namespace Student
{
    public class Global : System.Web.HttpApplication, IRequiresSessionState
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //返回json
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
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

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            HttpSessionState session = HttpContext.Current.Session;
            if (session == null)
                return;
            if (!this.Request.Path.Contains("Login") && session["USER"] == null)
            {
                //Response.Redirect("/View/Login/Login.aspx");
            }
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