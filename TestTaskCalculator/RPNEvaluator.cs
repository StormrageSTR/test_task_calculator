using System;
using System.Collections.Generic;

namespace TestTaskCalculator;

// Вычисление выражения в обратной польской нотации (RPN)
public static class RPNEvaluator
{
    public static double EvaluateRPN(List<string> rpnExpression)
    {
        var operandStack = new Stack<double>();

        foreach (var item in rpnExpression)
        {
            if (CalculatorHelper.IsNumber(item))
            {
                operandStack.Push(double.Parse(item));
            }
            else if (CalculatorHelper.IsOperator(item))
            {
                var operand2 = operandStack.Pop();
                var operand1 = operandStack.Pop();

                switch (item)
                {
                    case "+":
                        operandStack.Push(operand1 + operand2);
                        break;
                    case "-":
                        operandStack.Push(operand1 - operand2);
                        break;
                    case "*":
                        operandStack.Push(operand1 * operand2);
                        break;
                    case "/":
                        if(operand2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        operandStack.Push(operand1 / operand2);
                        break;
                }
            }
        }

        return operandStack.Pop();
    }
}