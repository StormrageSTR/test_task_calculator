namespace TestTaskCalculator;

public static class Calculator
{
    public static void StartEvaluation(string expression)
    {
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

        return RPNEvaluator.EvaluateRPN(rpnList);
    }
    
   
}