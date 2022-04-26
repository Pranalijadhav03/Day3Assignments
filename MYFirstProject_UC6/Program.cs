using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstProject_UC6
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;

        static void Main(string[] args)
        {
            int emphrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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


                totalEmpHrs += emphrs;
                Console.WriteLine(" Day :" + totalWorkingDays + "Emp Hrs :" + emphrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee wage : " + totalEmpWage);
            Console.ReadKey();



        }
    }
}
