

namespace Assignment_2_v._3
{
    class Spouse
    {
        public int Age;
        public string FirstName;
        public static int Count = 1;
        public void SpouseData()
        {
            System.Console.WriteLine("please enter Spouse  " + Count + " First  Name  ");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine(" please enter Spouse " + Count + " Age ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(this.FirstName + " " + Age);
        }
    }
}
