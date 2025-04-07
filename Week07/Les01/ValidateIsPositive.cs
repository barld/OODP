// See https://aka.ms/new-console-template for more information
public class ValidateIsPositive : IValidateInputValue<int>
{
    public string ErrorMessage => "Value must be a positive number";
    public bool IsValid(int value)
    {
        return value > 0;
    }
}
