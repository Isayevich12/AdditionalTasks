using System;

namespace AdditionalTasks2_SortinganExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myExpression = "privet1 mir vsem";

            //string[] arrString = myExpression.Split(' ');

            //Console.WriteLine(arrString[0].Length);

            //foreach (var item in arrString)
            //{
            //    Console.WriteLine(item);
            //}


            string v = SorterExpression.SortExpression(" hello word my");
            Console.WriteLine(v);
        }
    }
}
