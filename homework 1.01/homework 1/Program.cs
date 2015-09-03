using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer;
            int userAge;
            int heightFeet;
            bool isCitizen;
            bool canVote; 
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            double heightInches;

            double totalHeightCM;
           

        



            System.Console.Write("What is your age ?");
            userAge = int.Parse(System.Console.ReadLine());
                       
            System.Console.Write("what is your first name? ");
            firstName = System.Console.ReadLine(); 
                       
            System.Console.Write("what is you middle initial ?");
            middleInitial = System.Console.ReadLine();
            
            System.Console.Write("What is you last name ?");
            lastName = System.Console.ReadLine();
            
            System.Console.Write("What is you height Feets only  ");
            heightFeet = int.Parse(System.Console.ReadLine());
            
            System.Console.Write("what is you height Inces only  ");
            heightInches = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Are you a Citizen?");
            System.Console.WriteLine("true for YES, and false for NO");
            isCitizen = bool.Parse(System.Console.ReadLine());
          
            canVote = (18 <= userAge) && isCitizen;
            

            
            fullName = "[" +firstName +" "+ middleInitial +" " + lastName+"]";
            totalHeightCM = ((12*heightFeet)+heightInches) *2.54;
            System.Console.WriteLine("your age is.." + userAge);
            System.Console.WriteLine("your full name is.." + fullName);
            System.Console.WriteLine("your height is .." + totalHeightCM + "cm");
            System.Console.WriteLine("yourVoting status is   " + canVote);
            System.Console.WriteLine("if is true you can VOTE, if is false you CAN NOT VOTE ");         
            System.Console.ReadKey(true);

            System.Console.ReadKey();
        }
    }
}
