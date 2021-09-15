using System;

namespace Employee_wage_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("UC1 output");
           
            UC1_EmployeeAttendance obj1 = new UC1_EmployeeAttendance(); 
            obj1.GetAttendance();

            

            Console.WriteLine("UC2 output");
            
            UC2_EmpWage obj2 = new UC2_EmpWage();
            obj2.EmpWage();



            Console.WriteLine("UC3 output");

            UC3_PartTimeEmpWage obj3 = new UC3_PartTimeEmpWage();
            obj3.PartTimeEmpWage();



            Console.WriteLine("UC4 output");
            
            UC4_EmpWageUsingSwitch obj4 = new UC4_EmpWageUsingSwitch();
            obj4.EmpWageUsingSwitch();


            Console.WriteLine("UC5 output");

            UC5_CalculateWagesFor20DaysInMonth obj5 = new UC5_CalculateWagesFor20DaysInMonth();
            obj5.CalculateWagesFor20DaysInMonth();


            Console.WriteLine("UC6 output");
            
            UC6_CalculateWageTill100HrsOr20IsReached obj6 = new UC6_CalculateWageTill100HrsOr20IsReached();
            obj6.CalculateWageTill100HrsOr20IsReached();


            Console.WriteLine("UC7 output");
            
            UC7_ComputeEmpWageUsingClassMethod obj7 = new UC7_ComputeEmpWageUsingClassMethod();
            obj7.ComputeEmpWage();


            Console.WriteLine("UC8 output");
            
            UC8_ComputeEmpWageForMultipleCompanies obj8 = new UC8_ComputeEmpWageForMultipleCompanies();
            obj8.ComputeEmpWage("xyz", 10, 2, 8);
            Console.ReadKey();
        }
    }
}
