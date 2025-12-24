using LearnFree.Models;

namespace LearnFree
{
    class Program
    {
        static void Main()
        {
            var unic = new University("Aqtobe University");
            var compScience = unic.CreateDepartment("Computer Science");
            var math = unic.CreateDepartment("Mathematics");

            unic.HireTeacher(compScience!, new Teacher("Alice", "Programming", 70000));
            unic.HireTeacher(compScience!, new Teacher("Bob", "Informatics", 65000));

            Console.WriteLine("Before Hiring Charlie:");
            unic.DisplayAllInfo();

            unic.HireTeacher(math!, new Teacher("Charlie", "Algebra", 60000));

            Console.WriteLine("After Hiring Charlie:");

            unic.DisplayAllInfo();

            Console.WriteLine("Firing Alice from Unic");
            unic.FireTeacher(compScience!, compScience!.Teachers.First(t => t.Name == "Alice"));

            Console.WriteLine("After Firing:");
            unic.DisplayAllInfo();
        }
    }
}