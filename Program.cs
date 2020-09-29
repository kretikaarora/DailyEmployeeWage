using System;

namespace DailyWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            Random rand = new Random();
            int empcheck = rand.Next(0, 2);
            if (empcheck == 1)
            {
                Console.WriteLine("employee is present!");
            }
            else
            {
                Console.WriteLine("employee is absent!");
            }
          
          /// employee check program
          



        }
    }
}
