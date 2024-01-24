using ExercicioExcecao.Entities;
using ExercicioExcecao.Entities.AccountExceptions;

namespace Exercicio
{
    class Program
    {
        static void Main (string[] args)
        {
            System.Console.WriteLine("Enter account data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());
            Account acc = new Account(number, holder, balance, limit);
            
            System.Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                acc.Withdraw(amount);
                Console.Write("New balance: " + acc.Balance);
            }
            catch (DomainException e)
            {
                Console.Write("Withdraw error: " + e.Message);
            }
        }
    }
}