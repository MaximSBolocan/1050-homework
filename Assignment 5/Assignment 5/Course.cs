
namespace Assignment_5
{
    class Course
    {
        private string CourseName;
        private int CRNNumber;
        private Student[] StudentList;
        
        public  void CourseCreation()
        {
            string courseName;
            int courseNumber; ;
            courseName = Question.SceenQuestion("what is you course name?     :");
            courseNumber = Question.AskForInteger("what is you course number? :");
            CourseName = courseName;
            CRNNumber = courseNumber;
        }
        public void CreationOfStudent()
        {
            int nrOfStudents;
            nrOfStudents = Question.AskForInteger("how many students?   :");
            StudentList = new Student[nrOfStudents];
            for (int i=0;i<nrOfStudents;i++)
            {
                StudentList[i] = new Student();
                StudentList[i].StudentInformation();

            }
            foreach (Student student in StudentList)
            {
                student.Print();
            }

        }
    }
}
