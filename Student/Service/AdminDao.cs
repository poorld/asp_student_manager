using Assets.Common.Dao;
using Student.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Service
{
    public class AdminDao : CommonDao<AdminEntity>
    {

        public AdminEntity login(AdminEntity admin)
        {
            return base.selectByField(admin);
        }

        public void updatePassword(AdminEntity admin)
        {
            base.update(admin);
        }

        protected override int initId()
        {
            return 20001;
        }
    }
}