
namespace Assignment_2_v._3
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Spouse Spouse = new Spouse();
        static int TotalPersonAge = 0;
        static int PersonCount = 0;
        
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
            TotalPersonAge += Age;
        }
        public void NexStep()///
        {
            if (Spouse.Status.Answer())// we have to answer to the question. if we recive a 'true ' we go to 
                //get information about Spouse so we have to go to Spouse.SpouseData() 

            {
                Spouse.SpouseData();

            }

            else // if the answer was false we get the mesage bellow 
            {
                System.Console.WriteLine("Marital status : No ");

            }



        }
        public int TotalAge()
        {
            return TotalPersonAge + Spouse.SpouseAge();
        }
        public int TotalCount()
        {
            return PersonCount + Spouse.TotalSpouseCount();
        }
        static double AverageAge;///this is the part were i got stucked have no idea 
        // how to make this one to show in the main program becousse this is static it doesnt show in the main program 
        //its shows only here in Person class in order to show in main program ,it has to be converted into a method 
        //  
        public double FinalAverageAge()
        {
           AverageAge= TotalAge() / TotalCount();
            return AverageAge;
        } //problem solved converted it to a methode 
    }
}
