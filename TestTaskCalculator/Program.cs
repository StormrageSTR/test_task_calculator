using System;
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