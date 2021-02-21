using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTasks2_SortinganExpression
{
    enum TypeSort
    {
        up = 0,//режим от меньшего к большему 
        down,//режим от большего к меньшему 
    }

    class MySorterExpression
    {
        public string Expression { get; }
        private readonly string[] bufferArrayOfWords;
        private readonly int[] bufferArrayOfAmountCharInWord;
        private readonly string[] SortedBufferArrayOfWords;

        public MySorterExpression(string expression)
        {         
            this.Expression = expression;
            bufferArrayOfWords = expression.Split(' ');
            bufferArrayOfAmountCharInWord = new int[bufferArrayOfWords.Length];
            this.SortedBufferArrayOfWords = new string[bufferArrayOfWords.Length];
            int k = 0;
            foreach (var item in bufferArrayOfWords)
            {
                bufferArrayOfAmountCharInWord[k] = item.Length;
                SortedBufferArrayOfWords[k] = item;
                k++;
            }

        }

        private  void SortByMethodShells(int[] inArray, TypeSort typeSort)//Сортировка с изменением массива, typeSort-режим сортировки  
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
                                ChangeValue(ref SortedBufferArrayOfWords[j], ref SortedBufferArrayOfWords[j-step]);
                                
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
                                ChangeValue(ref SortedBufferArrayOfWords[j], ref SortedBufferArrayOfWords[j - step]);
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

        public void ChangeValue(ref string a,  ref string b)
        {
            string buf = a;
            a = b;
            b = buf;
        }

        public string InvokSortMethd( TypeSort typeSort)
        {
            SortByMethodShells(bufferArrayOfAmountCharInWord, typeSort);

            string sortedExpression = string.Empty;

            foreach (var item in SortedBufferArrayOfWords)
            {
                sortedExpression += item + " ";
            }
            return sortedExpression;
        }



    }
}
