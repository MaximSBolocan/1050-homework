using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Student
    {
        
        private string StudentName;
        private int SNumber;

        public  void  StudentInformation()
        {
            string studentName;
            int studentNumber;
            studentName=Question.SceenQuestion("enter student name       :");
            studentNumber = Question.AskForInteger("enter student number   :");
            StudentName = studentName;
            SNumber = studentNumber;
             

        }
    }
}
