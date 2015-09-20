

namespace Assignment_2_v._3
{
    class Spouse
    {
        public int Age;
        public string FirstName;
        static int SpouseCount = 0;
        static int TotalSpouseAge = 0;
        public Family Status = new Family();
        public void SpouseData()
        {
            SpouseCount++;
            System.Console.WriteLine("please enter Spouse   First  Name  ");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine(" please enter Spouse  Age ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(this.FirstName + " " + Age);
            TotalSpouseAge += Age;
        }// here we came after answering 'true " to the answer from Family.Answer()
        public int SpouseAge()
        {
            return TotalSpouseAge;
        }
        public int TotalSpouseCount()
        {
            return SpouseCount;
        }
    }
}
