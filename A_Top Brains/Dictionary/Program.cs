// Given a dictionary of (EmployeeId, Salary) and a list of EmployeeIds, return the total salary.

// Input
// Ids: {1, 4, 5}
// Dictionary: {1:20000, 4:40000, 5:15000}

// Output
// 75000
public class Dict
{
    public int EmployeeId { get; set; }
    public double Salary { get; set; }
    public Dict() { }
    public Dict(int employeeId, double salary)
    {
        EmployeeId = employeeId;
        Salary = salary;
    }
    public static Dictionary<int, double> Emp = new Dictionary<int, double>();
    public void AddVal(Dict dict)
    {
        Emp.Add(dict.EmployeeId, dict.Salary);
    }
    public double TotalSalary(List<int> emp)
    {
        double totol = 0;
        foreach (var i in emp)
        {
            if (Emp.ContainsKey(i))
            {
                totol += Emp[i];
            }
        }
        return totol;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Dict d = new Dict();

        d.AddVal(new Dict(1, 23000));
        d.AddVal(new Dict(2, 40000));
        d.AddVal(new Dict(3, 59333));
        d.AddVal(new Dict(4, 50000));

        List<int> keys = new List<int> { 1, 3, 4 };
        Console.WriteLine($" Total Salary : {d.TotalSalary(keys)}");
    }
}