﻿using System;

namespace DailyWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int ISS_PART_TIME = 2;
            int EMPLOYEE_RATE_PER_HOUR = 20;
            int empHrs;
            int totalWAage;
            Random rand = new Random();
            int empcheck = rand.Next(0, 3);
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empcheck==ISS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            totalWAage = empHrs * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("The total wage of worker per day is {0}",totalWAage);
          
          
          



        }
    }
}
