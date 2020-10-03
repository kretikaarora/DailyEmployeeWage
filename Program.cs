﻿using System;

namespace DailyWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int ISS_PART_TIME = 2;
            const int EMPLOYEE_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS_PERMONTH = 20;
            int empHrs;
            int totalWAage=0;
            int totalEmpHours = 0;
            Random rand = new Random();
            for (int day = 0; day < NUM_OF_WORKING_DAYS_PERMONTH; day++)
            {
                int empcheck = rand.Next(0, 3);

                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case ISS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }
                totalEmpHours = totalEmpHours+empHrs;
            }
            totalWAage = totalEmpHours * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("The total wage of worker per month is {0}", totalWAage);

        }

            
          
          
          



        }
    }

