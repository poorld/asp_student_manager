using Assets.Common.Entity;
using Newtonsoft.Json;
using Student.Common.Response;
using Student.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student.View.Ajax
{
    public class StudentController : ApiController
    {
        StuDao dao = new StuDao(); 

        //获取所有学生
        // GET api/<controller>
        public string Get()
        {
            List<StudentEntity> stus = dao.findStudents();
            var json = JsonConvert.SerializeObject(stus);
            return json;
        }

        //根据id获取学生
        // GET api/<controller>/5
        public string Get(int id)
        {
            
            return JsonConvert.SerializeObject(dao.getStuById(id));
        }

        //添加学生
        // POST api/<controller>
        public string Post([FromBody]string value)
        {
            //StudentEntity stu = JsonConvert.DeserializeObject<StudentEntity>(value);
            //stu.StuId = dao.getId();
            //dao.addStu(stu);
            dao.test();
            return JsonConvert.SerializeObject(new ResultResponse(200, "success"));
        }

        //修改学生
        // PUT api/<controller>/5
        public string Put([FromBody]string value)
        {
            StudentEntity stu = JsonConvert.DeserializeObject<StudentEntity>(value);
            dao.updateStu(stu);
            return JsonConvert.SerializeObject(new ResultResponse(200, "success"));
        }

        //删除学生
        // DELETE api/<controller>/5
        public string Delete(int id)
        {
            dao.deleteStu(id);
            return JsonConvert.SerializeObject(new ResultResponse(200, "success"));
        }
    }
}