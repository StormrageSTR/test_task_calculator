namespace TestTaskCalculator;

public static class Calculator
{
    public static void StartEvaluation()
    {
        Console.WriteLine("Введите математическое выражение:");
        var expression = Console.ReadLine();

        try
        {
           
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}