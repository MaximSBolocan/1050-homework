

namespace Assignment_2_v._3
{
    class Family
    {
        public bool Maried;
        public bool Answer()
        {
            System.Console.WriteLine(" are you maried ?");
            Maried = bool.Parse( System.Console.ReadLine());                        
            return Maried;
        }
        
    }
}
