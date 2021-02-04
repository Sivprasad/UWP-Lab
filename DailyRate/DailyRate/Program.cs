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
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(CalculateFee(dailyRate, noOfDays));
        }

        private void writeFee(double v) => Console.WriteLine($"The calculation Fees is {v * 1.1} ");
        

        private double CalculateFee(double dailyRate, int noOfDays) =>  dailyRate* noOfDays;
        private int readInt(string v) 
        {
            Console.Write(v);
            int noOfDays = int.Parse(Console.ReadLine());
            return noOfDays;
        }

        private double readDouble(string v)
        {
            Console.WriteLine(v);
            double dailyRate = double.Parse(Console.ReadLine());
            return dailyRate;
        }
    }
}
