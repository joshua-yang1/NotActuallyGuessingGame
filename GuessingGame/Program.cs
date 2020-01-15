using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int costPerPerson = 13;
            int numberOfDiners = 4;
            int totalBill = numberOfDiners * costPerPerson;
            Console.WriteLine(totalBill);
            if (totalBill >= 50)
            {
                double newTotalBill = totalBill * .9;
                Console.WriteLine(newTotalBill);
                Console.ReadLine();
            }
            else
            {
                double newTotalBill = totalBill * .95;
                Console.WriteLine(newTotalBill);
                Console.ReadLine();
            }
        }
    }
}
