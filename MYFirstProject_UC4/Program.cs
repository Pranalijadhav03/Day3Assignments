using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstProject_UC4
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwage = 0;
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
            Console.WriteLine("The Employee wage of the day is : " + empwage);
            Console.ReadKey();


        }
    }
}
