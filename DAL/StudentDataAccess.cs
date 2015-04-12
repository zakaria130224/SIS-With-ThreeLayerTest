using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DAL
{
    public class StudentDataAccess
    {
      

        #region saveStudentInfo
        
        
        public bool saveStudentInfo(Student s)
        {

           try
            {
                StreamWriter write = new StreamWriter("E:\\text.txt", true);
                write.WriteLine(s.roll);
                write.WriteLine(s.name);
                write.WriteLine(s.batch);
                write.WriteLine(s.year);
                write.WriteLine(s.term);
                write.WriteLine(s.address);
                write.WriteLine(s.contact);
                write.Close();
                return true;
            }
           catch (Exception )
           {
               return false;
           }
        }
        #endregion

        #region getStudentInfo

        public Student[] getStudentInfo()
        {
            Student[] s = new Student[50];
            
            try
            {
                StreamReader r = new StreamReader("E:\\text.txt");

                String temp=r.ReadLine();
                for (int i = 0; temp!=null; i++)
                {
                    s[i] = new Student();
                    s[i].roll = temp;
                    s[i].name = r.ReadLine();
                    s[i].batch = r.ReadLine();
                    s[i].year = r.ReadLine();
                    s[i].term = r.ReadLine();
                    s[i].address = r.ReadLine();
                    s[i].contact = r.ReadLine();
                    temp = r.ReadLine();                
                }
                r.Close();
                return s;
            }
            catch (Exception)
            {
                return null;
                throw;
               
            }
        }
        #endregion
    }
}
