using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTasks1_SortArrays
{
    class RandomArray// Класс- генератор интового массива  
    {
        public int[] Array { get;  }
        private static Random random = new Random();

        public RandomArray()
        {    
            Array = new int[random.Next(3, 10)];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(100);
            }
        }

    }
}
