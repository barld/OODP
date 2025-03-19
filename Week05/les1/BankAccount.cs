public class BankAccount
{
    // Private veld voor het saldo
    private decimal balance;

    // Public eigenschap voor de naam van de rekeninghouder
    private string accountHolder;

    // Constructor om de rekeninghouder en het beginsaldo in te stellen
    public BankAccount(string accountHolder, decimal initialBalance)
    {
        this.accountHolder = accountHolder;
        balance = initialBalance;

        new BankAccount("asd", 14m).balance = 20m;
    }

    public string GetAccountHolder()
    {
        return this.accountHolder;
    }

    public void SetAccountHolder(string value)
    {
        this.accountHolder = value;
    }

    private void UpdateBalance(decimal amount)
    {
        balance += amount;
        // add some extra logic here
        // like updating database or sending notifications
    }

    // Public methode om geld te storten
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            UpdateBalance(amount);
            Console.WriteLine($"{amount} is gestort. Nieuw saldo: {balance}");
        }
        else
        {
            Console.WriteLine("Bedrag moet positief zijn.");
        }
    }

    // Public methode om geld op te nemen
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            UpdateBalance(-amount);
            Console.WriteLine($"{amount} is opgenomen. Nieuw saldo: {balance}");
        }
        else
        {
            Console.WriteLine("Onvoldoende saldo of ongeldig bedrag.");
        }
    }
    public decimal GetBalance()
    {
        return balance;
    }
}