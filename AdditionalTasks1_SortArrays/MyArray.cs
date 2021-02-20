using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTasks1_SortArrays
{
    class MyArray
    {
        private int[] myArr;

        private RandomArray randomArray;

        public MyArray()
        {
            this.randomArray = new RandomArray();
            this.myArr = randomArray.Array;
        }

        public MyArray(params int[] array)
        {
            this.myArr = array;
        }

        public int this[int index]
        {
            get { return myArr[index]; }
            set { myArr[index] = value; }
        }

        public void ShowArray()
        {
            foreach (var item in myArr)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();
        }

        public void SortArry (TypeSort typeSort)
        {
            if (typeSort == TypeSort.down)
            {
                Sorter.SortByMethodShells(this.myArr, TypeSort.down);
            }
            else
            {
                Sorter.SortByMethodShells(this.myArr, TypeSort.up);
            }
        }


    }
}
