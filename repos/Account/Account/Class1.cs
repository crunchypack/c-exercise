using System;

public class AccountC
{
    private decimal balance;
	public AccountC(decimal inBalance)
	{
        Balance = inBalance;
	}
    public void Credit (decimal amount)
    {
        Balanace = Balance + amount;
    }
    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0) balance = value;
        }
    }
}
