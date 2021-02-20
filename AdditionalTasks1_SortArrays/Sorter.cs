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

        public static void SortByMethodShells(int[] inArray, TypeSort typeSort, out int[] outArray)//Сортировка без изменением массива, typeSort-режим сортировки  
        {
            outArray = new int[inArray.Length];
            for (int k = 0; k < inArray.Length; k++)
            {
                outArray[k] = inArray[k];
            }
            int i, j, step;
            int temporaryBuffer;
            for (step = outArray.Length / 2; step > 0; step /= 2)
                for (i = step; i < outArray.Length; i++)
                {
                    temporaryBuffer = outArray[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (typeSort == TypeSort.down)// выбран режим сортировки от меньшего к большему
                        {
                            if (temporaryBuffer > outArray[j - step])
                            {
                                outArray[j] = outArray[j - step];
                            }
                            else
                            {
                                break;
                            }
                        }
                        else// выбран режим сортировки от большего к меньшему
                        {
                            if (temporaryBuffer < outArray[j - step])
                            {
                                outArray[j] = outArray[j - step];
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    outArray[j] = temporaryBuffer;
                }
        }




    }
}
