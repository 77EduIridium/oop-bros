
namespace ReadonlyConst.Models
{
    class University
    {
        public const string Country = "Aqtobe";
        public readonly int FoundedYear;

        public University(int foundedYear) =>
            FoundedYear = foundedYear;
    }
}