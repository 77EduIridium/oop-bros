namespace LearnFree.Models
{
    public class University(string name)
    {
        public string Name { get; set; } = name;
        public List<Department> Departments { get; set; } = [];

        public Department? CreateDepartment(string name)
        {
            if (!Departments.Any(d => d.Name == name))
            {
                var department = new Department(name);
                Departments.Add(department);
                return department;
            }
            return null;
        }

        public Department? GetDepartment(string name) =>
            Departments.FirstOrDefault(d => d.Name == name);
        
        public void RemoveDepartment(Department department) =>
            Departments.Remove(department);
        
        public void HireTeacher(Department department, Teacher teacher)
        {
            if (Departments.Contains(department))
                department.AddTeacher(teacher);
        }

        public void FireTeacher(Department department, Teacher teacher)
        {
            if (Departments.Contains(department))
                department.RemoveTeacher(teacher);
        }

        public int GetTotalTeachers() =>
            Departments.Sum(d => d.Teachers.Count);
        public decimal GetHighestPaidTeacher() =>
            Departments.SelectMany(d => d.Teachers)
                       .Max(t => t.Salary);
        
        public void DisplayAllInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"University: {Name}");
            foreach (var dept in Departments)
            {
                Console.WriteLine($" Department: {dept.Name}");
                foreach (var teacher in dept.Teachers)
                    Console.WriteLine($"  Teacher: {teacher.Name}, Subject: {teacher.Subject}, Salary: {teacher.Salary}");
            }

            Console.WriteLine($"Total Teachers: {GetTotalTeachers()}");
            Console.WriteLine($"Highest Paid Teacher Salary: {GetHighestPaidTeacher()}");
            Console.WriteLine($"Departments Count: {Departments.Count}");
            Console.WriteLine();
        }
    }
}