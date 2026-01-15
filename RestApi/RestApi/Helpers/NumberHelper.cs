namespace RestApi.Helpers;

public class NumberHelper
{
    public static decimal ConvertToDecimal(string number)
    {
        if (decimal.TryParse(number, 
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimal result))
        {
            return result;
        }
        
        return 0;
    }

    public static bool IsNumeric(string value)
    {

        decimal decimalValue;
        bool isNumeric = decimal.TryParse(value, 
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out decimalValue);
        
        return isNumeric;
    }
}