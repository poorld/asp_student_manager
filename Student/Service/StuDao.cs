using Assets.Common.Dao;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Service
{
    public class StuDao : CommonDao<StudentEntity>
    {

        public List<StudentEntity> findStudents()
        {
            List < StudentEntity >  students = base.findAll();
            return students;
        }

        public StudentEntity login(StudentEntity stu)
        {
            return base.selectByField(stu);
        }

        public void addStu(StudentEntity stu)
        {
            base.insert(stu);
        }

        public void updateStu(StudentEntity stu)
        {
            base.update(stu);
        }

        protected override int initId()
        {
            return 1000;
        }

        public int getId()
        {
            return base.getLastId() + 1;
        }

        public StudentEntity getStuById(int id)
        {
            return base.findById(id);
        }

        public void deleteStu(int id)
        {
            base.delete(id);
        }

        public void test()
        {
            StudentEntity s = new StudentEntity();
            s.StuId = 1000;
            s.StuName = "gg";
            s.StuSex = "男";
            base.selectByField(s);
        }
    }
}