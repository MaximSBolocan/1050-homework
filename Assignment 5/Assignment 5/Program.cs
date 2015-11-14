

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer1;            
            Course SaveCourse;
            Answer1 =Question.AskForString("create a new course?     :");
             while (Answer1.ToLower().StartsWith("y"))
            {
                Course _course = new Course();
                _course.CourseCreation();
                _course.CreationOfStudent();
                SaveCourse = _course;
                Answer1 = Question.AskForString("do you whant to create a new course or fix a mistake?");
            }           
            System.Console.WriteLine("press any key");
            System.Console.ReadKey();
        }
    }
}
