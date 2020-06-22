using Assets.Common.Attributes;
using Assets.Common.Enums;
using Student.Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 学生
    /// </summary>
    [TableAlias("stu")]
    public class StudentEntity : TableEntity
    {
        private int stuId;
        [TableField("stu_id", "int", true)]
        public int StuId
        {
            get { return stuId; }
            set { stuId = value; }
        }

        private string stuNo;
        [TableField("stu_no", "nvarchar(50)")]
        public string StuNo
        {
            get { return stuNo; }
            set { stuNo = value; }
        }

        private string stuName;
        [TableField("stu_name", "nvarchar(50)")]
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        private string stuSex;
        [TableField("stu_sex", "int")]
        [EnumField(typeof(SexState))]
        public string StuSex
        {
            get { return stuSex; }
            set { stuSex = value; }
        }

        private int stuAge;
        [TableField("stu_age", "int")]
        public int StuAge
        {
            get { return stuAge; }
            set { stuAge = value; }
        }

        /// <summary>
        /// 班级
        /// </summary>
        private string stuGrade;
        [TableField("stu_grade", "nvarchar(50)")]
        public string StuGrade
        {
            get { return stuGrade; }
            set { stuGrade = value; }
        }

        private string stuProfession;
        [TableField("stu_profession", "nvarchar(50)")]
        public string StuProfession
        {
            get { return stuProfession; }
            set { stuProfession = value; }
        }

        /// <summary>
        /// 班级
        /// </summary>
        private string stuClass;
        [TableField("stu_class", "nvarchar(50)")]
        public string StuClass
        {
            get { return stuClass; }
            set { stuClass = value; }
        }


        /// <summary>
        /// 籍贯
        /// </summary>
        private string stuNativePlace;
        [TableField("stu_native_place", "nvarchar(50)")]
        public string StuNativePlace
        {
            get { return stuNativePlace; }
            set { stuNativePlace = value; }
        }

        /// <summary>
        /// 联系方式
        /// </summary>
        private string stuContact;
        [TableField("stu_contact", "nvarchar(50)")]
        public string StuContact
        {
            get { return stuContact; }
            set { stuContact = value; }
        }

        private string stuAddress;
        [TableField("stu_address", "nvarchar(50)")]
        public string StuAddress
        {
            get { return stuAddress; }
            set { stuAddress = value; }
        }

    }
}
