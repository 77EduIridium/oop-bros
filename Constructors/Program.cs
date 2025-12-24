using Constructors.Models;

namespace Constructors
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("Хищник", "Александр Сергеевич Контрович", 2018);
            Book book2 = new("Alisher History");

            book1.PrintInfo();
            book2.PrintInfo();
        }
    }
}