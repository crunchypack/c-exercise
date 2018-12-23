using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    private decimal balance;
    public Account(decimal inBalance)
    {
        Balance = inBalance;
    }
    public void Credit(decimal amount)
    {
        Balance = Balance + amount;
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
