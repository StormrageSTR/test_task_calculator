namespace TestTaskCalculator;

public static class Calculator
{
    public static void StartEvaluation()
    {
        Console.WriteLine("Введите математическое выражение:");
        var expression = Console.ReadLine();

        try
        {
            var result = EvaluateExpression(expression);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    
    private static double EvaluateExpression(string expression)
    {
        expression = expression.Replace(" ", "");
        var rpnList = RPNSequenceConverter.ConvertToRPN(expression);

        //временная заглушка
        return default;
    }
    
   
}