using System;

public class SimpleAccounting
{
    public static void Main(string[] args)
    {
        string[] incomeStrings = { "100", "200", "ad", "33", "400" }; // Пример неправильный
        double totalIncome = 0;

        try
        {
            foreach (string incomeStr in incomeStrings)
            {
                double income = double.Parse(incomeStr); // Попытка преобразовать строку в число
                totalIncome += income;
            }
            Console.WriteLine($"Общая сумма доходов: {totalIncome}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: Некорректный формат ввода. {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Ошибка: Переполнение. Число слишком большое. {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Обработка завершена.");
        }
    }
}