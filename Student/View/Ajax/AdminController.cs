using Newtonsoft.Json;
using Student.Common.Entity;
using Student.Common.Response;
using Student.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;

namespace Student.View.Ajax
{
    public class AdminController : ApiController
    {
        AdminDao dao = new AdminDao();

        public string Get()
        {
            return "";
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "";
        }

        //登录
        // POST api/<controller>
        public string Post([FromBody]string value)
        {
            HttpSessionState session = HttpContext.Current.Session;
            LoginEntity login = JsonConvert.DeserializeObject<LoginEntity>(value);
            AdminEntity admin = new AdminEntity();
            admin.AdminNo = login.Username;
            admin.AdminPass = login.Password;
            AdminEntity adminEntity =  dao.login(admin);
            if (adminEntity != null)
            {

            }

            return "";
        }
        // PUT api/<controller>/5
        public string Put([FromBody]string value)
        {
            AdminEntity admin = JsonConvert.DeserializeObject<AdminEntity>(value);
            dao.updatePassword(admin);
            return JsonConvert.SerializeObject(new ResultResponse(200, "success"));
        }

        // DELETE api/<controller>/5
        public string Delete(int id)
        {
            return "";
        }
    }
}
