using Overload.PrinterSystem;

namespace Overload
{
    class Program
    {
        static void Main()
        {
            Printer.Print("Hello, World!");
            Printer.Print("Repeat this line", 3);
        }
    }
}