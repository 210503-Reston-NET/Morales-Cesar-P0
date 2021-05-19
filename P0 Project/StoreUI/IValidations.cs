namespace StoreUI
{
    public interface IValidations
    {
         string ValidateString(string prompt);
         int ValidateInt(string prompt);
         double ValidateDouble(string prompt);
    }
}