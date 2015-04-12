using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BO
{
    public class StudentBO
    {

        StudentDataAccess sda = new StudentDataAccess();

        public bool saveStudentInfo(Student s)
        {
            return sda.saveStudentInfo(s);
        }


        public Student[] getStudentInfo()
        {
            return sda.getStudentInfo();
        }
    }
}
