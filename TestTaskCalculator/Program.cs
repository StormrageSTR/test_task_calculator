using TestTaskCalculator;

Console.WriteLine("Введите математическое выражение:");
var expression = Console.ReadLine();

try
{
    var result = Calculator.StartEvaluation(expression);
    Console.WriteLine($"Результат: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

//var result = Calculator.StartEvaluation("2 + 3 * (5 - 1)");
// Assert.Equal(14, result);
