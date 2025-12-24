namespace Overload.PrinterSystem
{
    class Printer
    {
        public static void Print(string text) =>
           Console.WriteLine(text);

        public static void Print(string text, int repeat)
        {
            for (int i = 0; i < repeat; i++)
                Print(text);
        }
    }
}