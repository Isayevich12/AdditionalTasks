using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_UserCollectionQueueWithPriority
{
    class UserQueue<T> : IEnumerable, IEnumerator where T : IPriority
    {
        private T[] Subjects { get; set; }
        private int LenghtQueue { get; set; }
        private int position = -1;

        public UserQueue()
        {
            Subjects = new T[1];

            this.LenghtQueue = 0;
        }

        public T this[int index]// индексатор
        {
            get
            {
                if (Subjects[0] is null)
                {
                    return (T)(object)null;
                }
                else
                {
                    return Subjects[index];
                }


            }
        }

        public void AddItem(T item)// добавляет элемент в коллекцию
        {
            if (this.LenghtQueue == 0)
            {
                this.LenghtQueue++;
                this.Subjects[0] = item;
            }
            else
            {
                T[] buffArr = new T[Subjects.Length + 1];

                for (int i = 0; i < Subjects.Length; i++)
                {
                    buffArr[i] = Subjects[i];
                }

                buffArr[Subjects.Length] = item;


                this.Subjects = buffArr;

                this.LenghtQueue++;

                SortByMethodShells();
            }

        }



        object IEnumerator.Current
        {
            get
            {
                return Subjects[position];
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }

        bool IEnumerator.MoveNext()
        {
            if (position < Subjects.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                position = -1;// reset           

                return false;
            }
        }

        void IEnumerator.Reset() // реализация метода Reset() интерфеса IEnumerator
        {

        }

        private void SortByMethodShells()//Сортировка с изменением массива 
        {
            int i, j, step;
            int temporaryBuffer;
            for (step = this.Subjects.Length / 2; step > 0; step /= 2)
                for (i = step; i < this.Subjects.Length; i++)
                {
                    temporaryBuffer = this.Subjects[i].Priority;
                    for (j = i; j >= step; j -= step)
                    {
                        if (temporaryBuffer < this.Subjects[j - step].Priority)
                        {
                            ChangeValue(ref this.Subjects[j], ref this.Subjects[j - step]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    this.Subjects[j].Priority = temporaryBuffer;
                }
        }

        private void ChangeValue(ref T a, ref T b)// обменивает ссылки переменных а и b
        {
            T buf = a;
            a = b;
            b = buf;
        }

        public T UseFirstItem() // использование первого элемента в очереди (без удаления его)
        {
            return this.Subjects[0];
        }

        public T ReleaseFistItem() // использование первого элемента в очереди (с удалением его)
        {
            if (LenghtQueue == 0)
            {
                return (T)(object)null;
            }
            else
            {
                this.LenghtQueue--;

                T buffItem = this.Subjects[0];

                T[] buffArr = new T[LenghtQueue];

                for (int i = 0; i < LenghtQueue; i++)
                {
                    buffArr[i] = this.Subjects[i + 1];
                }

                this.Subjects = buffArr;

                return buffItem;
            }
        }

    }
}
