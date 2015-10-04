

namespace Assignment_3
{
    class Student
    {
        private string Name;
        public int Grade=0;
        private Instructor Teacher;
        
         
        public Student(string name,Instructor teacher,int setgrade)
        {
            this.Name = name;                       
            this.Teacher = teacher;
            this.Grade = setgrade;
        }
            
         public void PrintNameGradeTeacher()
        {
         System.Console.WriteLine(this.Name + " " + this.Grade + " "+ Teacher.Name+" "+Teacher.CourseName );
        }  
       
    }
}
