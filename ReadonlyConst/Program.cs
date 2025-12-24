using ReadonlyConst.Models;

namespace ReadonlyConst
{
    class Program
    {
        static void Main()
        {
            var uni = new University(1487 + 1);
            Console.WriteLine($"Country: {University.Country}, Founded Year: {uni.FoundedYear}");
        }
    }
}