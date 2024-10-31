namespace TestTaskCalculator;

public class RPNSequenceConverter
{
    // Преобразование в обратную польскую нотацию (RPN)
    public static List<string> ConvertToRPN(string expression)
    {
        var output = new List<string>();
        var operatorStack = new Stack<string>();

        var items = SplitExpression(expression);

        foreach (var item in items)
            if (CalculatorHelper.IsNumber(item))
                output.Add(item);
            else if (CalculatorHelper.IsOperator(item))
                AddOperatorToStack(operatorStack, item, output);
            else
                AddBracetsAndOperatorsInBracets(item, operatorStack, output);

        while (operatorStack.Count > 0) output.Add(operatorStack.Pop());

        return output;
    }

    private static void AddBracetsAndOperatorsInBracets(string item, Stack<string> operatorStack, List<string> output)
    {
        switch (item)
        {
            case "(":
                operatorStack.Push(item);
                break;
            case ")":
            {
                while (operatorStack.Count > 0 && operatorStack.Peek() != "(") output.Add(operatorStack.Pop());

                operatorStack.Pop();
                break;
            }
        }
    }

    private static void AddOperatorToStack(Stack<string> operatorStack, string item, List<string> output)
    {
        while (operatorStack.Count > 0
               && CalculatorHelper.IsOperator(operatorStack.Peek())
               && CalculatorHelper.GetOperatorPrecedence(item) <= CalculatorHelper.GetOperatorPrecedence(operatorStack.Peek()))
            output.Add(operatorStack.Pop());

        operatorStack.Push(item);
    }

    // Метод для разделения выражения
    private static List<string> SplitExpression(string expression)
    {
        var items = new List<string>();
        var i = 0;
        while (i < expression.Length)
        {
            var currentChar = expression[i];

            if (CalculatorHelper.IsNumber(currentChar.ToString()))
            {
                var startIndex = i;
                while (i < expression.Length &&
                       (CalculatorHelper.IsNumber(expression[i].ToString()) || expression[i] == '.'))
                    i++;

                items.Add(expression.Substring(startIndex, i - startIndex));
            }
            else
            {
                // Считываем оператор или скобку
                items.Add(currentChar.ToString());
                i++;
            }
        }

        return items;
    }
}