using System;
namespace PayRoll_Calculator
{
    class Employee
    {
        public string Name { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
    }

    class PayrollCalculator
    {
        public double CalculateRegularPay(Employee emp)
        {
            return Math.Min(emp.HoursWorked, 40) * emp.HourlyRate;
        }

        public double CalculateOvertimePay(Employee emp)
        {
            if (emp.HoursWorked <= 40)
                return 0;

            return (emp.HoursWorked - 40) * emp.HourlyRate * 1.5;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();

            Console.Write("Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Hours Worked: ");
            if (!double.TryParse(Console.ReadLine(), out double hours) || hours < 0 || hours > 300)
            {
                Console.WriteLine("Invalid Hours.");
                return;
            }

            Console.Write("Hourly Rate: ");
            if (!double.TryParse(Console.ReadLine(), out double rate) || rate < 0)
            {
                Console.WriteLine("Invalid Rate.");
                return;
            }

            emp.HoursWorked = hours;
            emp.HourlyRate = rate;

            PayrollCalculator payroll = new PayrollCalculator();

            double regular = payroll.CalculateRegularPay(emp);
            double overtime = payroll.CalculateOvertimePay(emp);
            double gross = regular + overtime;

            Console.WriteLine($"\nEmployee : {emp.Name}");
            Console.WriteLine($"Regular Pay : {Math.Round(regular, 2)}");
            Console.WriteLine($"Overtime Pay : {Math.Round(overtime, 2)}");
            Console.WriteLine($"Gross Salary : {Math.Round(gross, 2)}");
        }
    }
}
