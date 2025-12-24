namespace LearnFree.Models
{
    public class Teacher(string name, string subject, decimal salary = 0m)
    {
        public string Name { get; set; } = name;
        public string Subject { get; set; } = subject;
        public decimal Salary { get; set; } = salary;
    }
}