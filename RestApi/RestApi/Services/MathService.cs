using RestApi.Helpers;

namespace RestApi.Services;

public class MathService
{
    public decimal Sum(string firstNumber, string secondNumber) =>
        NumberHelper.ConvertToDecimal(firstNumber) + NumberHelper.ConvertToDecimal(secondNumber);
        
    
    
    public decimal Substract(string firstNumber, string secondNumber) =>
        NumberHelper.ConvertToDecimal(firstNumber) - NumberHelper.ConvertToDecimal(secondNumber);

    
    public decimal Multiplication(string firstNumber, string secondNumber) =>
        NumberHelper.ConvertToDecimal(firstNumber) * NumberHelper.ConvertToDecimal(secondNumber);



    public decimal Division(string firstNumber, string secondNumber)
    {
        if(secondNumber == "0")
            throw  new DivideByZeroException("Não é possível dividir por zero");
        
        return NumberHelper.ConvertToDecimal(firstNumber) / NumberHelper.ConvertToDecimal(secondNumber);
    }
 
    
    public decimal Average(string firstNumber, string secondNumber) =>
        (NumberHelper.ConvertToDecimal(firstNumber) + NumberHelper.ConvertToDecimal(secondNumber) / 2);

    public double Sqr(string number)
    {
        if (number == "0")
            throw new ArgumentOutOfRangeException("Não é possível calcular a raiz quadrada de um número negativo.");
        
        return  Math.Sqrt((double)NumberHelper.ConvertToDecimal(number));

    }
 
}