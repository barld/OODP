// See https://aka.ms/new-console-template for more information
public class ValidateIsLessThan : IValidateInputValue<int>
{
    private readonly int maxValue;
    
    public ValidateIsLessThan(int maxValue)
    {
        this.maxValue = maxValue;
    }
    
    public string ErrorMessage => $"Value must be less than {maxValue}";
    public bool IsValid(int value)
    {
        return value < maxValue;
    }
}
