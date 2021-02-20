using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdditionalTasks2_SortinganExpression
{
    static class SorterExpression
    {
        public static string SortExpression(string expression)
        {
            string[] tempArrOfWords = expression.Split(' ');

            Dictionary<int, string> tempDict = new Dictionary<int, string>();//TKey - колво цифр, Tvalue - слово

            foreach (var item in tempArrOfWords)
            {
                tempDict.Add(item.Length, item);
            }

            var sortedsortedDict = new SortedDictionary<int, string>(tempDict);

            string a = " ";
            foreach (var item in sortedsortedDict)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value);

                a +=item.Value;
            }


            return a;
        }


    }
}
