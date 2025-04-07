// See https://aka.ms/new-console-template for more information
public class ValidateIsEmail : IValidateInputValue<string>
{
    public string ErrorMessage => "Value is not a valid email";
    public bool IsValid(string value)
    {
        return value.Contains("@");
    }
}
