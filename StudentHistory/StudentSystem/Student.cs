namespace StudentHistory.StudentSystem
{
    public enum StudyForm { FullTime, PartTime };
    class Student
    {
        static int studentCount = 0;

        public string Name { get; set; }
        public int Course { get; set; }

        public Student(string name, int course)
        {
            Name = name;
            Course = course;
            studentCount++;
        }

        public StudyForm Form { get; set; } = StudyForm.FullTime;

        public void PrintInfo() =>
            Console.WriteLine($"Name: {Name}, Course: {Course}, {Form}");

        public static void PrintStudentCount() =>
            Console.WriteLine($"Total Students: {studentCount}");
    }
}