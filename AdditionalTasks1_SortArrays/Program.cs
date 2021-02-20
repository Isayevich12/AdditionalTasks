using System;

namespace AdditionalTasks1_SortArrays
{
    class Program
    {
        static void Main(string[] args)
        {         
            MyArray myArr1 = new MyArray();

            Console.WriteLine("Изначальный массив->");
            myArr1.ShowArray();
            Console.WriteLine(new string('_',50));

            Console.WriteLine("После сортировки->");
            myArr1.SortArry(TypeSort.down);

            myArr1.ShowArray();

            myArr1.SortArry(TypeSort.up);

            myArr1.ShowArray();
        }
    }
}
