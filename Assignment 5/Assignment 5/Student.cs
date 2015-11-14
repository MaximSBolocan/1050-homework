
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
            studentName=Question.AskForString("enter student name       :");
            studentNumber = Question.AskForInteger("enter student number   :");
            StudentName = studentName;
            SNumber = studentNumber;
         }
        public  void Print()
        {
            System.Console.WriteLine(StudentName+" "+SNumber);           
        }
    }
}
