namespace TestTaskCalculator;

//Хелпер для методов
public static class CalculatorHelper
{
    public static bool IsOperator(string token)
        => token is "+" or "-" or "*" or "/";

    public static bool IsNumber(string token)
        => double.TryParse(token, out _);

    // Метод определения приоритета оператора
    public static int GetOperatorPrecedence(string token)
        => token switch
        {
            "+" or "-" => 1,
            "*" or "/" => 2,
            _ => 0
        };
}