﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstProject_UC5
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random obj = new Random();
                int empCheck = obj.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;

                    case IS_PART_TIME:
                        emphrs = 4;
                        break;

                    default:
                        emphrs = 0;
                        break;

                }

                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empwage;
                Console.WriteLine("Employee Wage :" + empwage);
            }
            Console.WriteLine("Total Employee wage : " + totalEmpWage);
            Console.ReadKey();



        }
    }
}