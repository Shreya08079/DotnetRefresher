public abstract class PayrollSystem
{
    public abstract void GetSalary();
}
public class HourlyEmpolyee : PayrollSystem
{
    public decimal Hour{get; set;}
    public decimal Rate{get; set;}
    public HourlyEmpolyee(){}
    public HourlyEmpolyee(decimal hour, decimal rate)
    {
        Hour = hour;
        Rate = rate;
    }
    public override void GetSalary()
    {
        decimal res = Hour * Rate;
        Console.WriteLine($"Salary of Hourly Employee "+res);
    }
}
public class SalariedEmployee : PayrollSystem
{
    public decimal Salary{get; set;}
    public SalariedEmployee(){}
    public SalariedEmployee(decimal salary)
    {
        Salary = salary;
    }
    public override void GetSalary()
    {
        Console.WriteLine($"Salary of Salaried Employee "+Salary);
    }
}
public class CommissionEmployee : PayrollSystem
{
    public decimal Commision{get; set;}
    public decimal BaseSalary{get; set;}
    public CommissionEmployee(){}
    public CommissionEmployee(decimal commision, decimal baseSalary)
    {
        Commision = commision;
        BaseSalary = baseSalary;
    }
    public override void GetSalary()
    {
        decimal totalSalary = Commision+BaseSalary;
        Console.WriteLine($"Salary of Commission Employee {totalSalary}");
    }
}
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEnter quit to exit.....");
            Console.WriteLine("Enter H for Hour Based Employee");
            Console.WriteLine("Enter S for Salaried Employee");
            Console.WriteLine("Enter C for Commission Employee");

            string? str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            if (str.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Exiting Payroll System...");
                break;
            }

            PayrollSystem employee = null;

            switch (str.ToUpper())
            {
                case "H":
                    Console.Write("Enter Working Hours: ");
                    decimal hours = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter Rate per Hour: ");
                    decimal rate = decimal.Parse(Console.ReadLine());

                    employee = new HourlyEmpolyee(hours, rate);
                    break;

                case "S":
                    Console.Write("Enter Monthly Salary: ");
                    decimal salary = decimal.Parse(Console.ReadLine());

                    employee = new SalariedEmployee(salary);
                    break;

                case "C":
                    Console.Write("Enter Commission Amount: ");
                    decimal commission = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter Base Salary: ");
                    decimal baseSalary = decimal.Parse(Console.ReadLine());

                    employee = new CommissionEmployee(commission, baseSalary);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    continue;
            }

           
            employee.GetSalary();
        }
    }
}