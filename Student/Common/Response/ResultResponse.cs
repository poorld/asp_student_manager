using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Common.Response
{
    public class ResultResponse
    {
        public int code;
        public string msg;
        public object data;

        public ResultResponse(int code, string msg)
        {
            this.code = code;
            this.msg = msg;
        }

        public ResultResponse(int code, string msg, object data)
        {
            this.code = code;
            this.msg = msg;
            this.data = data;
        }
    }
}