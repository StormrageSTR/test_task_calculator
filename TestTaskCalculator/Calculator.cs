namespace TestTaskCalculator;

public static class Calculator
{
    public static double StartEvaluation(string expression)
    {
        var result = EvaluateExpression(expression);
        return result;
    }

    private static double EvaluateExpression(string expression)
    {
        expression = expression.Replace(" ", "");
        var rpnList = RPNSequenceConverter.ConvertToRPN(expression);

        return RPNEvaluator.EvaluateRPN(rpnList);
    }
}