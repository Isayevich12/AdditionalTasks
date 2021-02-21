using System;

namespace AdditionalTasks1_SortArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //тут не заморачивался

            MyArray myArr1 = new MyArray();

            Console.WriteLine("Изначальный массив1->");
            myArr1.ShowArray();
            Console.WriteLine(new string('_', 50));
            Console.WriteLine("После сортировки методом Шелла->");
            myArr1.SortArrayShall(TypeSort.down);
            myArr1.ShowArray();
            myArr1.SortArrayShall(TypeSort.up);
            myArr1.ShowArray();
            Console.WriteLine(new string('_', 50));

            MyArray myArr2 = new MyArray();

            Console.WriteLine("Изначальный массив2->");
            myArr2.ShowArray();
            Console.WriteLine(new string('_', 50));
            Console.WriteLine("После сортировки методом QuickSort->");
            myArr2.QuickSort();
            myArr2.ShowArray();
            Console.WriteLine(new string('_', 50));


        }
    }
}
