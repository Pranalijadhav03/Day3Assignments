﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world1
{
    internal class EmpWageUC1
    {
        public static void EmployeeAttendance()
        {
            int IS_FULL_TIME = 1;
            Random obj = new Random();
            int empCheck = obj.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();

        }
    }
}