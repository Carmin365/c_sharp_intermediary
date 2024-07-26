public class BankAccount
{
    public string Holder { get; set; }
    private double balance;

    public void Deposit(double value)
    {
        balance += valor;
    }

    public void To_withdraw(double value)
    {
        if (value > balance)
        {
            throw new Exception("Insufficient funds.");
        }
        balance -= value;
    }
}

