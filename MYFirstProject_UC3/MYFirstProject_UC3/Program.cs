using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstProject_UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int empCheck = obj.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                emphrs = 8;

            }
            else if (empCheck == IS_PART_TIME)
            {
                emphrs = 4;

            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee wage of the day is : " + empwage);
            Console.ReadKey();
        }
    }
}
