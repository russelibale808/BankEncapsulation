namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount();
            myBank.GetBalance();
            myBank.Deposit(10000);
            myBank.GetBalance();
            myBank.Withdraw(500);
            myBank.GetBalance();
        }
    }
}
