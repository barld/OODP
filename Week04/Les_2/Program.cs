// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    int zero = int.Parse("0");
    int answer = 5/zero;
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);

    throw new Exception("Ik kan hier niks mee", ex);
}
catch(DivideByZeroException e) when (e.InnerException is not null)
{
    Console.WriteLine("don't devide by zero");
}
finally
{

}

void DoSomething(string arg1)
{
    if (string.IsNullOrWhiteSpace(arg1))
    {
        throw new ArgumentNullException(nameof(arg1));
    }
}