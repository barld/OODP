// See https://aka.ms/new-console-template for more information
public class ReadValueFromConsole<T>
{
    public required IEnumerable<IValidateInputValue<T>> Validators { get; init; }
    public required IParseInputValue<T> Parser { get; init; }
    
    public T GetValue()
    {
        T result = default;
        bool valid = false;
        while (!valid)
        {
            string input = Console.ReadLine();
            if (Parser.TryParse(input, out result))
            {
                valid = false;
                foreach (var validator in Validators)
                {
                    if (!validator.IsValid(result))
                    {
                        Console.WriteLine(validator.ErrorMessage);
                        valid = false;
                        break;
                    }
                    valid = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }
        }
        return result;
    }
}
