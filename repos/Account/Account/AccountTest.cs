public class AccountTest
{
    public static void Main(string[] args)
    {
        Account acc1 = new Account(50.00M);
        acc1.Credit(49.99M);
        System.Console.WriteLine("Account balance: {0:C}",acc1.Balance);
    }
}