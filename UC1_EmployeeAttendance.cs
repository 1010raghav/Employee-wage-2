﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_2
{
    class UC1_EmployeeAttendance
    {
        public  void GetAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }

    }
}
