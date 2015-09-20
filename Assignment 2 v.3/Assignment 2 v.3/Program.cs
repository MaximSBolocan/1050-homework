
namespace Assignment_2_v._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();//creat new person
            Person1.GetFullName();//geting full name 
            Person1.PrintNameAndAge(); // printing  fullname and age                        
            Person1.NexStep();//geting information about spouse if it has one,  go and se person.Nextstep() method            
            
            Person Person2 = new Person();
            Person2.GetFullName();
            Person2.PrintNameAndAge();
            Person2.NexStep();
           
            Person Person3 = new Person();
            Person3.GetFullName();
            Person3.PrintNameAndAge();
            Person3.NexStep();
            System.Console.WriteLine(" The Average Age is " +Person3.FinalAverageAge());//this will be the average age 
            //of all persons not so good as a code                        
            System.Console.WriteLine("pres any key to continue..");
            System.Console.ReadKey();
            
        }
    }
}
