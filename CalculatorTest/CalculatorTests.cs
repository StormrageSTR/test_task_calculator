using TestTaskCalculator;

namespace CalculatorTest;

public class CalculatorTests
{
    [Theory]
    [InlineData("1 + 2 - 3", 0)]
    [InlineData("10 + (4 * 3 + (5 / 2))", 24.5)]
    [InlineData("(7 * 2) + 25 - (84 / 3)", 11)]
    public void ExpressionEvaluatedTest(string expression, double expectedResult)
    {
        Assert.Equal(expectedResult, Calculator.StartEvaluation(expression));
    }
    
    [Theory]
    [InlineData("  ", "Stack empty.")]
    [InlineData("1 +", "Stack empty.")]
    [InlineData("* 1", "Stack empty.")]
    public void ExpressionFailedTest(string expression, string errorMessage)
    {
        try
        {
            Calculator.StartEvaluation(expression);
        }
        catch (Exception e)
        {
            Assert.True(errorMessage == e.Message);
        }
    }
    
    [Theory]
    [InlineData("1 / 0", "Attempted to divide by zero.")]
    [InlineData("1 / (10 - 5 * 2)", "Attempted to divide by zero.")]
    public void ExpressionDivideByZeroTest(string expression, string errorMessage)
    {
        try
        {
            Calculator.StartEvaluation(expression);
        }
        catch (Exception e)
        {
            Assert.True(errorMessage == e.Message);
        }
    }
}