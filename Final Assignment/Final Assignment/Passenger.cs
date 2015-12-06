
namespace Final_Assignment
{
    class Passenger
    {
        private string Name;
        private double Weight;
        public Passenger(string name,double weigth)
        {
            Name = name;
            Weight = weigth;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetWeight()
        {
            return Weight;
        }
    }
}
