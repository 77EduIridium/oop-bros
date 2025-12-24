class Program
{
    record Passport(string Number, string Country) {}

    static void Main()
    {
        var passport1 = new Passport("123456789", "KZ");
        var recordedPassport = passport1 with { Number = "123456788" };

        Console.WriteLine(passport1);
        Console.WriteLine(recordedPassport);
        Console.WriteLine(passport1.Country == recordedPassport.Country);
        Console.WriteLine(ReferenceEquals(passport1, recordedPassport));
    }
}