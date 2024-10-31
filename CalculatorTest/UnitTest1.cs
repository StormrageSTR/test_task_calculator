using TestTaskCalculator;

namespace CalculatorTest;

public class UnitTest1
{
    [Theory]
    [InlineData("1 + 2 - 3", 0)]
    [InlineData("10 + (4 * 3 + (5 / 2))", 24.5)]
    [InlineData("(7 * 2) + 25 - (84 / 3)", 11)]
    public void ExpressionEvaluatedTest(string expression, double expectedResult)
    {
        Assert.Equal(expectedResult, Calculator.StartEvaluation(expression));
    }
}