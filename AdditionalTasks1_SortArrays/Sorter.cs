using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTasks1_SortArrays
{
    enum TypeSort
    {
        up = 0,//режим от меньшего к большему 
        down,//режим от большего к меньшему 
    }
    static class Sorter
    {
        public static void SortByMethodShells(int[] inArray, TypeSort typeSort)//Сортировка с изменением массива, typeSort-режим сортировки  
        {
            int i, j, step;
            int temporaryBuffer;
            for (step = inArray.Length / 2; step > 0; step /= 2)
                for (i = step; i < inArray.Length; i++)
                {
                    temporaryBuffer = inArray[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (typeSort == TypeSort.down)// выбран режим сортировки от меньшего к большему
                        {
                            if (temporaryBuffer > inArray[j - step])
                            {
                                inArray[j] = inArray[j - step];
                            }
                            else
                            {
                                break;
                            }
                        }
                        else// выбран режим сортировки от большего к меньшему
                        {
                            if (temporaryBuffer < inArray[j - step])
                            {
                                inArray[j] = inArray[j - step];
                            }
                            else
                            {
                                break;
                            }
                        }
                                                
                    }
                    inArray[j] = temporaryBuffer;
                }
        }






    }
}
