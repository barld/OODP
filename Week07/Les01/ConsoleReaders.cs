// See https://aka.ms/new-console-template for more information
public static class ConsoleReaders
{
    public static ReadValueFromConsole<string> ReadEmail { get; } = new ReadValueFromConsole<string>
    {
        Validators = new List<IValidateInputValue<string>> { new ValidateNotEmptyString(), new ValidateIsEmail() },
        Parser = new ParseString()
    };

    public static ReadValueFromConsole<string> ReadTitle { get; } = new ReadValueFromConsole<string>
    {
        Validators = new List<IValidateInputValue<string>> { new ValidateNotEmptyString() },
        Parser = new ParseString()
    };

    public static ReadValueFromConsole<int> ReadAge { get; } = new ReadValueFromConsole<int>
    {
        Validators = new List<IValidateInputValue<int>> { new ValidateIsPositive(), new ValidateIsLessThan(100) },
        Parser = new ParseInt()
    };
}
