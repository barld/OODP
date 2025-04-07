// See https://aka.ms/new-console-template for more information
public interface IParseInputValue<T>
{
    public bool TryParse(string Value, out T result);
}
