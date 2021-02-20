using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTasks1_SortArrays
{
    class RandomArray
    {
        public int[] Array { get;  }
        private static Random random = new Random();

        public RandomArray()
        {    
            int lenghtArray = random.Next(3, 10);

            Array = new int[lenghtArray];

            for (int i = 0; i < lenghtArray; i++)
            {
                Array[i] = random.Next(100);
            }
        }

    }
}
