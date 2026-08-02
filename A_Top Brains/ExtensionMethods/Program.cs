using ExtensionMethods;

namespace ExtensionMethodDemo
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new()
            {
                new() { Id = 1, Name = "Kamaljeet" },
                new() { Id = 2, Name = "Rahul" },
                new() { Id = 1, Name = "Ankit" }
            };
            List<Student> res = students.GetDistinct();
            foreach(var student in res)
            {
                Console.WriteLine(student.Name);
            }
        }
        
        public static List<Student> GetDistinct(this List<Student> students)
        {
            return students.DistinctBy(s => s.Name).ToList();
        }
    }
}