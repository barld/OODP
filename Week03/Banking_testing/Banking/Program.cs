// See https://aka.ms/new-console-template for more information
Account account = new Account();
try
{
    account.Deposit(100);
    double withdrawAmount = double.Parse(Console.ReadLine());

    account.Withdraw(withdrawAmount);
}
catch(FormatException ex)
{
    Console.WriteLine("Je hebt het verkeerde format gebruikt");
}
catch(InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Dit wordt altijd uitgevoerd!");
}



