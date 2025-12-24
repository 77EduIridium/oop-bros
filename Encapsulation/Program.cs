using Encapsulation.Models;

namespace Encapsulation
{
    class Program
    {
        static void Main()
        {
            var card = new BankCard();

            card.Deposit(10000);
            card.Withdraw(5500);
            card.Withdraw(5000);
            card.Deposit(-500);
            card.Withdraw(0);
            card.Withdraw(-1);
        }
    }
}