
using StudentHistory.StudentSystem;

namespace StudentHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new("Bob", 16);
            Student student2 = new("Bab", 17);
            Student student3 = new("Lad", 18)
            {
                Form = StudyForm.PartTime
            };

            student.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();

            Student.PrintStudentCount();
        }
    }
}