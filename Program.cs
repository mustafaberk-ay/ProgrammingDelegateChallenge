//Additional risk fee of 25$
//Zone1 25%
//Zone2 12% + high risk fee
//Zone3 8%
//Zone4 4% + high risk fee

using System;

namespace ProgrammingDelegateChallenge
{
    internal class Program
    {
        delegate double calculateZone1(int itemPrice, double fee, bool isHighRisk);
        public static double calcZone1(int itemPrice, double fee, bool isHighRisk)
        {
            if (isHighRisk)
            {
                return itemPrice * fee + 25;
            }
            return itemPrice * fee;
        }

        static void Main(string[] args)
        {
            calculateZone1 calculateFee = calcZone1;
            Console.WriteLine("What is the destination zone?");
            string destinationZone = Console.ReadLine();

            while (destinationZone != "exit")
            {
                Console.WriteLine("What is the item price?");
                int itemPrice = Convert.ToInt32(Console.ReadLine());

                switch (destinationZone)
                {
                    case "zone1":
                        Console.WriteLine("The shipping fees are: {0:N2}", calculateFee(itemPrice, 0.25, false));
                        break;
                    case "zone2":
                        Console.WriteLine("The shipping fees are: {0:N2}", calculateFee(itemPrice, 0.12, true));
                        break;
                    case "zone3":
                        Console.WriteLine("The shipping fees are: {0:N2}", calculateFee(itemPrice, 0.08, false));
                        break;
                    case "zone4":
                        Console.WriteLine("The shipping fees are: {0:N2}", calculateFee(itemPrice, 0.04, true));
                        break;
                    default:
                        break;
                }

                Console.WriteLine("What is the destination zone?");
                destinationZone = Console.ReadLine();
            }
        }
    }
}