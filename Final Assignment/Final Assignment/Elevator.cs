

namespace Final_Assignment
{
    class Elevator
    {
        private double Maxweight;
        private Passenger[] Occupants;
        
        public Elevator(int maxOcupants, double maxWeight)
        {
            Maxweight = maxWeight;
            Occupants = new Passenger[maxOcupants];                       
        }
        public void AddOcupant(int index, Passenger passanger)
        {
            Occupants[index] = passanger;
        }
        public double  GetCurrentWeight()
        {
            double totalOccupantsWeight=0;
            foreach(Passenger passanger in Occupants)
            {
                totalOccupantsWeight += passanger.GetWeight();
            }
            return totalOccupantsWeight;
        }
        public bool IsOverMaxCap()
        {
            if (GetCurrentWeight()<=Maxweight)
            {
                return false;
            }
            else
            {
                return true;    
            }
         } 
    }
}
