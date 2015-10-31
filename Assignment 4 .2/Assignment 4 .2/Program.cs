namespace Assignment_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ShowTime;
            double TotalExpences=0;
            int NumberOFAdults;
            int NumberOfSeniors;
            int NuberOfChildren;
            int NumberOfCandy;
            int NumberOfHotddog;
            int NumberOfLargesoda;
            int NumberOfSmallSoda;
            int NumberOfPopcorn;
            int TotalNumOfPeople;
          
            
            System.Console.WriteLine("please enter show time (matine or evening )");
            ShowTime = System.Console.ReadLine();                        
            System.Console.WriteLine("enter nuber of children: ");
            NuberOfChildren = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter number of adults : ");
            NumberOFAdults= int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter number of seniors :");
            NumberOfSeniors= int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("enter nr of popcorn:     ");
            NumberOfPopcorn = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter nr of hotdog:      ");
            NumberOfHotddog = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter nr of large soda:  ");
            NumberOfLargesoda = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter nr of small soda:  ");
            NumberOfSmallSoda = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter nr of candy:       ");
            NumberOfCandy = int.Parse(System.Console.ReadLine());
            ///////////////////////////////////////////////////////////
            TotalNumOfPeople = NumberOFAdults + NumberOfSeniors + NuberOfChildren;

            if (ShowTime.ToLower().StartsWith("m"))
            {
                double child = 3.99;
                double adult = 5.99;
                double senior = 4.50;
                double MoneyForChildren=0;
                double MoneyForAdults=0;
                double MoneyForSeniors=0;
                if (NuberOfChildren>=1)
                {                   
                     MoneyForChildren=NuberOfChildren* child;
                }
                
                if (NumberOFAdults>=1)
                {
                    MoneyForAdults = NumberOFAdults * adult;
                }
                
                if (NumberOfSeniors>=1)
                {
                   MoneyForSeniors = NumberOfSeniors * senior;
                }
                
                 TotalExpences = MoneyForAdults + MoneyForChildren + MoneyForSeniors;
            }
            else
            {
                double child = 6.99;
                double adult = 10.99;
                double senior = 8.50;
                double MoneyForChildren=0;
                double MoneyForAdults=0;
                double MoneyForSeniors=0;

                if (NuberOfChildren >= 1)
                {

                    MoneyForChildren = NuberOfChildren * child;
                }
                
                if (NumberOFAdults >= 1)
                {
                    MoneyForAdults = NumberOFAdults * adult;
                }
                
                if (NumberOfSeniors >= 1)
                {
                    MoneyForSeniors = NumberOfSeniors * senior;
                }
                
                TotalExpences= MoneyForAdults + MoneyForChildren + MoneyForSeniors;
                if (TotalNumOfPeople>=3)
                {
                    System.Console.WriteLine("you have one free bag of popcorn");
                    TotalExpences =TotalExpences- 4.50;
                }
            }
            
            
            ////////////////////////////////////////////////////////////
           

            
                  if (NumberOfLargesoda >= 1 && NumberOfPopcorn>=1)
                    {
                        int Discount;
                       if (NumberOfLargesoda< NumberOfPopcorn)
                        {                            
                           Discount= NumberOfLargesoda * 2;
                        }
                       else if(NumberOfLargesoda>NumberOfPopcorn)
                        {
                            Discount = NumberOfPopcorn * 2;
                            
                        }
                       else
                        {
                            Discount = NumberOfLargesoda*2;
                        }
                        TotalExpences = TotalExpences - Discount;
                    }                                       
                                                      
            if (NumberOfCandy>=3)
            {
                TotalExpences += NumberOfCandy * 1.99;
                int extraCandies;
               extraCandies= NumberOfCandy / 3;
                NumberOfCandy += extraCandies;
            }
            else
            {
                TotalExpences += NumberOfCandy * 1.99;
            }
            TotalExpences = TotalExpences + (NumberOfHotddog * 3.99)+(NumberOfSmallSoda*3.5);           
            System.Console.WriteLine("total expences: " + " " + TotalExpences);
            System.Console.WriteLine("press any key to continue..");
            System.Console.ReadKey();
            
        }
    }
}
