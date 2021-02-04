using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            //double fee = calculateFee();
            //double fee = calculateFee(650.0);
            // double fee = calculateFee(500.0,3);
           double fee = calculateFee(theDailyrate: 375.0);
            Console.WriteLine($"Fee is {fee}");
        }
        private double calculateFee(double theDailyrate = 500.0, int noOfDays =1)
        {
            Console.WriteLine("CalculateFee using two optional parameters: ");
            return theDailyrate * noOfDays;
        }
        private double calculateFee(double dailyrate = 500.0 )
        {
            Console.WriteLine("CalculateFee using one optional parameters: ");
            int noOfDays = 1;
            return dailyrate * noOfDays;
        }

        private double calculateFee()
        {
            Console.WriteLine("CalculateFee using  hardcoded values ");
            double dailyrate = 400.0;
            int noOfDays = 1;
            return dailyrate * noOfDays;
        }
    }
}
