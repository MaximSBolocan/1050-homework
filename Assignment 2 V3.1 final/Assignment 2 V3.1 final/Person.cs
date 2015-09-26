using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_V3._1_final
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static int PersonCount = 0;
        public static int TotalPersonSAge = 0;
        public static int SpouseCount = 0;
        
        public string GetFullName()
        {
            PersonCount++;
            System.Console.WriteLine("please enter Person  " + PersonCount + " First Name  ");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("please enter Person  " + PersonCount + " Last Name  ");
            LastName = System.Console.ReadLine();

            return this.FirstName + " " + this.LastName + " ";
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(" please enter Person " + PersonCount + " Age ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(this.FirstName + " " + this.LastName + " " + Age);
            TotalPersonSAge += Age;
        }
        public void SpouseNameAge()//this method is part of family status methode 
        {
            System.Console.WriteLine(Spouse.FirstName + " " + Spouse.Age);
        }
        public void NewSpouse()
        {

            Spouse = new Person();
            
            SpouseCount++;
            System.Console.WriteLine("what is the spoouse FirstName?");
            Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine(" what is spouse age? ");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            TotalPersonSAge += Spouse.Age;



        }//this is the method how we created the new Spouse of type Person        
        public bool FamilyStatus()
        {
            System.Console.WriteLine(" Is this person maried ?");
            bool Answer;
            if (System.Console.ReadLine().ToLower().StartsWith("y"))//if the answer starts with "y"
                //the Answer will be true 
            {
                Answer = true;//when  answer is true a new spouse is created of type Person
                NewSpouse();//here we create a spouse and get all necesary information and mmake the conectionn between 
                //person X and his(her) spouse  
                
                SpouseNameAge();     
            }
            else
            {
                Answer = false;
                System.Console.WriteLine("This peson is not maried "); //but if the answer is false we just get a message
            }
            return Answer; //at the end this methode returns to us a true/false answer                       
                           
        }        
        public double AverageAge()
        {
            System.Console.WriteLine(" the average age is...");
             return TotalPersonSAge/(PersonCount+SpouseCount);
        }
    }
}
