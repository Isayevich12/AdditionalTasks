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

        public static void QuickSort(int[] numbers, int left, int right)
        {
            int pivot; // разрешающий элемент
            int l_hold = left; //левая граница
            int r_hold = right; // правая граница
            pivot = numbers[left];
            while (left < right) // пока границы не сомкнутся
            {
                while ((numbers[right] >= pivot) && (left < right))
                    right--; // сдвигаем правую границу пока элемент [right] больше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    numbers[left] = numbers[right]; // перемещаем элемент [right] на место разрешающего
                    left++; // сдвигаем левую границу вправо
                }
                while ((numbers[left] <= pivot) && (left < right))
                    left++; // сдвигаем левую границу пока элемент [left] меньше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    numbers[right] = numbers[left]; // перемещаем элемент [left] на место [right]
                    right--; // сдвигаем правую границу вправо
                }
            }
            numbers[left] = pivot; // ставим разрешающий элемент на место
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot) // Рекурсивно вызываем сортировку для левой и правой части массива
                QuickSort(numbers, left, pivot - 1);
            if (right > pivot)
                QuickSort(numbers, pivot + 1, right);
        }




    }
}
