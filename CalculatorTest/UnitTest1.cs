using TestTaskCalculator;

namespace CalculatorTest;

public class UnitTest1
{
    [Theory]
    [InlineData("1+2-3", 0)]
    public void ExpressionEvaluatedTest(string expression, int expectedResult)
    {
        Assert.Equal(expectedResult, Calculator.StartEvaluation(expression));
    }
}