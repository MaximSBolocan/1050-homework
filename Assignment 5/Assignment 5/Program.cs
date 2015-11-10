

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer1;            
            Course SaveCourse;
            Answer1 =Question.SceenQuestion("create a new course?     :");
             while (Answer1.ToLower().StartsWith("y"))
            {
                Course _course = new Course();
                _course.CourseCreation();
                _course.CreationOfStudent();
                SaveCourse = _course;
                Answer1 = Question.SceenQuestion("do you whant to create a new course or fix a mistake?");
            }           
            System.Console.WriteLine("press any key");
            System.Console.ReadKey();
        }
    }
}
//Lab 5 - Loops & Arrays

//Instructions:

 

//Create a class “Course”.
//Every Course has a Name.
//Every Course has a CRN Number.
//Every Course has a list of Students.


//Create a class “Student”.
//Every Student has a Name.
//Every Student has an S-Number.


//Allow the user to create a course.
//Ask for the course name.
//Ask for the course number.
//Ask how many students are in the course.
//Use a FOR Loop to create all of the students.
//Print the results to the screen.


//Ask the user if everything is correct.
//Allow the user to start over if they made a mistake.
//Use a WHILE Loop for this.
