// See https://aka.ms/new-console-template for more information
public class ParseString : IParseInputValue<string>
{
    public bool TryParse(string Value, out string result)
    {
        result = Value;
        return true;
    }
}
