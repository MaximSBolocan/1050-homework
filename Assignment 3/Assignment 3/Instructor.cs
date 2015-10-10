using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Instructor
    {
        public string Name { get; set; }
        public string CourseName { get; set; }

         public Instructor (string name,string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }
        public int  SetStudetGrade( Student name ,int grade)
        {
            name.Grade = grade;
            return grade;
           
        }
        public void PrintTeacherInformation()
        {          
            System.Console.WriteLine(this.Name + " " + this.CourseName);

        }
    }
}
