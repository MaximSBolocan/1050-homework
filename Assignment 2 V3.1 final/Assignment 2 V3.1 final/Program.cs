using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_V3._1_final
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Person1 = new Person();//creat new person
            Person1.GetFullName();//geting full name 
            Person1.PrintNameAndAge(); //printing on screen the inforation about our person
            Person1.FamilyStatus();// this methode helps as to create a spouse if person1 has one or just skips to the 
            //person 2 and starts geting all information about person 2
                     
            
            Person Person2 = new Person();//creat new person
            Person2.GetFullName();//geting full name 
            Person2.PrintNameAndAge(); // 
            Person2.FamilyStatus();

            Person Person3 = new Person();//creat new person
            Person3.GetFullName();//geting full name 
            Person3.PrintNameAndAge(); //
            Person3.FamilyStatus();
            System.Console.WriteLine("Aerage age is  " +Person3.AverageAge() );
            
            System.Console.WriteLine("Press any key to continue..");
            System.Console.ReadLine();
        }
    }
}
