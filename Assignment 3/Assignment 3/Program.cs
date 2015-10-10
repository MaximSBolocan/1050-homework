

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor johnh = new Instructor("johnh", "english");
            Instructor mike = new Instructor("Mike", "Math");
            Student jane = new Student("Jane", johnh,0);
            Student joe = new Student("Joe", johnh,0);
            Student melissa = new Student("Melisa", mike,0);
            Student matt = new Student("Matt", mike,0);
            /////////////////////////////////////////////////////////
            
           
            johnh.SetStudetGrade(jane, 95);
            johnh.SetStudetGrade(joe, 85);
            mike.SetStudetGrade(melissa, 90);
            mike.SetStudetGrade(matt, 92);
            /////////////////////////////////////////////////////////
            melissa.PrintNameGradeTeacher();
            jane.PrintNameGradeTeacher();
            joe.PrintNameGradeTeacher();
            matt.PrintNameGradeTeacher();
            //////////////////////////////////////////////////
            //johnh.PrintTeacherInformation();
            //mike.PrintTeacherInformation();
            System.Console.WriteLine("press any key to end.. ");
            System.Console.ReadKey();

        }
    }
}
