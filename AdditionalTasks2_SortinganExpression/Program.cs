using System;

namespace AdditionalTasks2_SortinganExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите предложение:");
            string expression = Console.ReadLine();
            Console.WriteLine($"{new string('_',50)}\nОтсортировано по возрастанию длины слов->\n{expression.SortExpression(TypeSort.up)}\n" +
                $"Отсортировано по убыванию длины слов->\n{expression.SortExpression(TypeSort.down)}");

        }
    }
}
