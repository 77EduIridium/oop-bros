namespace LearnFree.Models
{
    public class Department(string name)
    {
        public string Name { get; set; } = name;
        public List<Teacher> Teachers { get; set; } = [];

        public void AddTeacher(Teacher teacher)
        {
            if (!Teachers.Contains(teacher))
                Teachers.Add(teacher);
        }
        
        public void RemoveTeacher(Teacher teacher) =>
                Teachers.Remove(teacher);

        public decimal GetAverageSalary() => 
            Teachers.Count == 0 ? 0m : Teachers.Average(t => t.Salary);
    }
}