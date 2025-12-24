using CollectionS.Models;

namespace CollectionS
{
    class Program
    {
        static void Main()
        {
            var group = new Group("Mathematics");

            group.AddStudent(new("Alisher", 18, 3));
            group.AddStudent(new("Alisher", 18, 2));
            group.AddStudent(new("Alisher", 18, 1));
            group.AddStudent(new("Alisher", 18, 1));
            group.AddStudent(new("Alisher", 18, 1));
            group.AddStudent(new("Alisher", 18, 2));

            group.PrintAllStudents();

            var (count, avgCourse) = group.GetStatistics();
            
            Console.WriteLine($"Total Students: {count}, Average Course: {avgCourse}");
        }
    }
}