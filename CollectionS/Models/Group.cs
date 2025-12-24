
namespace CollectionS.Models
{
    class Group(string name)
    {
        public string Name { get; set; } = name;
        public List<Student> Students { get; set; } = [];

        public void AddStudent(Student student) =>
            Students.Add(student);

        public void PrintAllStudents()
        {
            Console.WriteLine($"Group: {Name}");

            foreach (var student in Students)
                Console.WriteLine($"- {student.Name}, Age: {student.Age}");
        }

        public (int count, int avgCourse) GetStatistics()
        {
            int count = Students.Count;
            return (count, count == 0 ? 0 : (int)Students.Average(s => s.Course));
        }
    }
}