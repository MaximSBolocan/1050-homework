
namespace Assignment_2_v._3
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Spouse Spouse = new Spouse();       
        public static int Count = 1;
        public Family Status = new Family();
        
        public string GetFullName()
        {
            System.Console.WriteLine("please enter Person  " + Count + " First  Name  ");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("please enter Perso  " + Count + " Last Name  ");
            LastName=System.Console.ReadLine();
           
            return this.FirstName + " " + this.LastName +" ";
        }  
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(" please enter Perso " + Count + " Age ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(this.FirstName + " " + this.LastName + " " + Age);
        }
        //public void AverageAge()
        //{
        // double TotalAge;
        //  System.Console.WriteLine("average age is ..");
        //  TotalAge= ((Age + Spouse.Age) / (Count + Spouse.Count-2));
        //  return TotalAge;
        //}
        public void NexStep()
        {
            if (Status.Answer()) 
            {
                Spouse.SpouseData();
            }
            else
            {
                Person.Count++;
                Spouse.Count++;
            }
        }
    }
}
