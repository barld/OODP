// See https://aka.ms/new-console-template for more information
public class ValidateNotEmptyString : IValidateInputValue<string>
{
    public string ErrorMessage => "Value can not be empty";
    public bool IsValid(string value)
    {
        return !string.IsNullOrEmpty(value);
    }
}
