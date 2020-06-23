using Assets.Common.Entity;
using Newtonsoft.Json;
using Student.Common.Constant;
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
        StuDao stuDao = new StuDao();

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
            AdminEntity loginAdmin =  dao.login(admin);
            if (loginAdmin != null)
            {
                session.Add(SessionContant.LoginUser, loginAdmin);
                session.Add(SessionContant.UserType, SessionContant.TypeAdmin);
                return JsonConvert.SerializeObject(new ResultResponse(200, "success", "/View/Query/StuQuery.aspx"));
            }
            else
            {
                StudentEntity stu = new StudentEntity();
                stu.StuNo = login.Username;
                stu.StuName = login.Password;
                StudentEntity loginStu = stuDao.login(stu);
                if (loginStu != null)
                {
                    session.Add(SessionContant.LoginUser, loginStu);
                    session.Add(SessionContant.UserType, SessionContant.TypeStudent);
                    return JsonConvert.SerializeObject(new ResultResponse(200, "success", "/View/Query/StuQuery.aspx"));
                }
            }


            return JsonConvert.SerializeObject(new ResultResponse(500, "fail", "登陆失败"));
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
