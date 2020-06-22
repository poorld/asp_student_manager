using Assets.Common.Entity;
using Newtonsoft.Json;
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

        // GET api/<controller>
        public string Get()
        {
            List<StudentEntity> stus = dao.findStudents();
            var json = JsonConvert.SerializeObject(stus);
            return json;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            StudentEntity stu = JsonConvert.DeserializeObject<StudentEntity>(value);
            dao.addStu(stu);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}