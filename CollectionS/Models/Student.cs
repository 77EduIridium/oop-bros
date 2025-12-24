
namespace CollectionS.Models
{
    class Student(string name, int age, int course = 1)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public int Course { get; set; } = course;
    }
}