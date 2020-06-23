using Assets.Common.Entity;
using Student.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student.Service.Add
{
    public partial class StuAdd : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            string action = string.Empty;
            string id = string.Empty;
            try
            {
                action = Request.QueryString["action"].ToString();
                id = Request.QueryString["id"].ToString();
            }catch(Exception ex){

            }
            if(!string.IsNullOrEmpty(action))
                stuSett.Value = action;
            if (!string.IsNullOrEmpty(action) && !string.IsNullOrEmpty(id))
                stuSett.Value = id;
        }
       
        
    }
}