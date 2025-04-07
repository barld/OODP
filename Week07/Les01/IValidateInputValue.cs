// See https://aka.ms/new-console-template for more information
public interface IValidateInputValue<T>
{
    public string ErrorMessage { get; }
    public bool IsValid(T value);
}
