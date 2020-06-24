using Assets.Common.Entity;
using Newtonsoft.Json;
using Student.Common.Constant;
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
    public class StuController : ApiController
    {

        StuDao dao = new StuDao(); 

        public string Get()
        {
            HttpSessionState session = HttpContext.Current.Session;
            StudentEntity stu = (StudentEntity)session[SessionContant.LoginUser];
            return JsonConvert.SerializeObject(new ResultResponse(200, "success", stu));
        }

        //修改学生
        // PUT api/<controller>/5
        public string Put([FromBody]string value)
        {

            HttpSessionState session = HttpContext.Current.Session;
            StudentEntity stu1 = (StudentEntity)session[SessionContant.LoginUser];

            StudentEntity stu2 = JsonConvert.DeserializeObject<StudentEntity>(value);
            stu2.StuId = stu1.StuId;

            stu1.StuNativePlace = stu2.StuNativePlace;
            stu1.StuContact = stu2.StuContact;
            stu1.StuAddress = stu2.StuAddress;

            dao.updateStu(stu2);
            return JsonConvert.SerializeObject(new ResultResponse(200, "success"));
        }

        //退出登录（放这里了...
        // DELETE api/<controller>/5
        public string Delete()
        {
            HttpSessionState session = HttpContext.Current.Session;
            session.Remove(SessionContant.LoginUser);
            return JsonConvert.SerializeObject(new ResultResponse(200, "success"));
        }
    }
}
