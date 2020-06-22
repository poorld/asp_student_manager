using Assets.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Common.Entity
{
    [TableAlias("admin")]
    public class AdminEntity : TableEntity
    {
        private string adminNo;
        [TableField("admin_no", "nvarchar(50)", true)]
        public string AdminNo
        {
            get
            {
                return adminNo;
            }
            set
            {
                adminNo = value;
            }
        }

        private string adminPass;
        [TableField("admin_pass", "nvarchar(50)")]
        public string AdminPass
        {
            get
            {
                return adminPass;
            }
            set
            {
                adminPass = value;
            }
        }
    }
}