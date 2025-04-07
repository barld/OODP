// See https://aka.ms/new-console-template for more information
public class ParseInt : IParseInputValue<int>
{
    public bool TryParse(string Value, out int result)
    {
        return int.TryParse(Value, out result);
    }
}
