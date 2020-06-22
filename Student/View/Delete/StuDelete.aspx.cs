using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student.Service.Delete
{
    public partial class StuDelete : System.Web.UI.Page
    {
        StuDao dao = new StuDao();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //删除
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stuId.Text))
                return;

            int id = Convert.ToInt32(stuId.Text);
   
            dao.deleteStu(id);

            Response.Write("<script language=javascript>alert('删除成功')</script>");
        }

        //查询
        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string id = stuId.Text;
            if (String.IsNullOrEmpty(id))
            {
                Response.Write("<script language=javascript>alert('没找到')</script>");
                return;
            }

            StudentEntity stu = dao.getStuById(Convert.ToInt32(id));
            if (stu != null)
            {
                stuId.Text = stu.StuId.ToString();
                stuName.Text = stu.StuName;
                stuSex.SelectedValue = stu.StuSex;
                stuAge.Text = stu.StuAge.ToString();
            }
        }
    }
}