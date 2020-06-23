using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student.View.Update
{
    public class UpdatePageController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // 修改学生
        // GET api/<controller>/5
        public string Get(int id)
        {
            string url = Request.RequestUri.Authority.ToString();
            Redirect(url + "/View/Add/StuAdd.aspx?action=update");
            return "";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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