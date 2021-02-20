using System;

namespace AdditionalTasks1_SortArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyArray myArr1 = new MyArray();

            //Console.WriteLine("Изначальный массив->");
            //myArr1.ShowArray();
            //Console.WriteLine(new string('_', 50));

            //Console.WriteLine("После сортировки->");
            //myArr1.SortArry(TypeSort.down);

            //myArr1.ShowArray();

            //myArr1.SortArry(TypeSort.up);

            //myArr1.ShowArray();


            int[] my = { 10, 4, 2, 14, 67, 2, 11, 33, 1, 15, 87,68, 99 };
            Sorter.QuickSort(my, 0, my.Length - 1);

            foreach (var item in my)
            {
                Console.Write(item.ToString()+" ");
            }


        }
    }
}
