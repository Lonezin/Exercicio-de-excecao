using ExercicioExcecao.Entities.AccountExceptions;

namespace ExercicioExcecao.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        
        public Account ()
        {
        }
        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException ("This amount is higher than the withdrawal limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("It is impossible to withdraw as the amount is greater than the value in the bank");
            }
            Balance -= amount;
        }
                
    }
}