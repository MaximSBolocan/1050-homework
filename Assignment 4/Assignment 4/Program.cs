
namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
         double TotalExpenses;
            //double child = 3.99;
            //double adult = 5.99;
            //double senior = 4.50;


            System.Console.Write("Are you planing to go to movie?");
            if (System.Console.ReadLine().ToLower().StartsWith("y")) //giving a positive answer
            {
                double PriceForTikets;
                System.Console.WriteLine("Are planing to go on Matine or Evening show ? ");
                if (System.Console.ReadLine().ToLower().StartsWith("m"))
                {
                    double child = 3.99;
                    double adult = 5.99;
                    double senior = 4.50;

                    System.Console.WriteLine("how many peolpe a going ?");
                    string Answer1 = System.Console.ReadLine();
                    int NumberOfPeolple = int.Parse(Answer1);

                    if (NumberOfPeolple >= 2)
                    {
                        System.Console.WriteLine("how many childs are going with you?");
                        int NumOfChildren = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("how many adults are going with you ?");
                        int NumOfAdults = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("how many seniors ?");
                        int NumOfSeniors = int.Parse(System.Console.ReadLine());
                        PriceForTikets = (NumOfChildren * child) + (NumOfAdults * adult) + (NumOfSeniors * senior);
                        TotalExpenses = PriceForTikets;
                        System.Console.WriteLine("total expensence are " + TotalExpenses);

                    }
                    else//im going by my self
                    {
                        System.Console.Write("are you adult, child, or senior ?");
                        string input = System.Console.ReadLine();
                        if (input.ToLower().Contains("a"))
                        {
                            TotalExpenses = 5.99;
                        }

                        if (input.ToLower().Contains("c"))
                        {
                            TotalExpenses = 3.99;
                        }
                        if (input.ToLower().Contains("s"))
                        {
                            TotalExpenses = 4.50;
                        }


                    }






                }
                else//im going evening
                {
                    double child = 6.99;
                    double adult = 10.99;
                    double senior = 8.50;

                    System.Console.WriteLine("how many peolpe a going ?");
                    string Answer1 = System.Console.ReadLine();
                    int NumberOfPeolple = int.Parse(Answer1);

                    if (NumberOfPeolple >= 2)
                    {
                        System.Console.WriteLine("how many childs are going with you?");
                        int NumOfChildren = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("how many adults are going with you ?");
                        int NumOfAdults = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("how many seniors ?");
                        int NumOfSeniors = int.Parse(System.Console.ReadLine());
                        PriceForTikets = (NumOfChildren * child) + (NumOfAdults * adult) + (NumOfSeniors * senior);
                        TotalExpenses = PriceForTikets;
                       
                    }
                    else//you are going by ypurself 
                    {
                        System.Console.Write("are you adult, child, or senior ?");
                        string input = System.Console.ReadLine();
                        if (input.ToLower().Contains("a"))
                        {
                            TotalExpenses = 10.99;
                        }

                        if (input.ToLower().Contains("c"))
                        {
                            TotalExpenses = 6.99;
                        }
                        if (input.ToLower().Contains("s"))
                        {
                            TotalExpenses = 8.50;
                        }

                    }


                }
            }
            else///i gave a negative answer
            {
                System.Console.WriteLine("you dont whant to go to movie ");
                TotalExpenses = 0;
            }


            System.Console.WriteLine("total expensence are ");
            System.Console.Write(TotalExpenses); 

            System.Console.WriteLine("pres any key to continue..");
                System.Console.ReadKey();
            }
        }
    }


