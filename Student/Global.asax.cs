using Student.Common.Constant;
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

        public override void Init()
        {
            //注册事件
            this.AuthenticateRequest += WebApiApplication_AuthenticateRequest;
            base.Init();
        }

        //开启session支持
        void WebApiApplication_AuthenticateRequest(object sender, EventArgs e)
        {
            //启用 webapi 支持session 会话
            HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
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

            string type = (string)session[SessionContant.UserType];
            object o = session[SessionContant.LoginUser];
            if (this.Request.Path.Contains("Admin") && this.Request.HttpMethod.ToUpper().Equals("POST"))
                return;

            if (this.Request.Path.Contains("__browserLink"))
                return;

            if (!this.Request.Path.Contains("Login") && session[SessionContant.LoginUser] == null)
            {
                Response.Redirect("/View/Login/Login.aspx");
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