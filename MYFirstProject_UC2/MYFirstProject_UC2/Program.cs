using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstProject_UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOURS = 20;
            int empWage = 0;
            int empHours = 0;
            Random obj = new Random();
            int empCheck = obj.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHours = 8;
            }

            else
            {
                empHours = 0;
            }
            empWage = empHours * EMP_RATE_PER_HOURS;

            Console.WriteLine("The Employee wage of the day is : " + empWage);
            Console.ReadKey();

        }
    }
}
