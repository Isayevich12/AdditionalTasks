using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_UserCollectionQueueWithPriority
{
    class UserQueue<T> : IEnumerable, IEnumerator where T : IPriority
    {
        private T[] Subjects { get; set; }      
        private int position = -1;

        public UserQueue()
        {
            this.Subjects = new T[1];

        }

        public T this[int index]// индексатор впринципе не нужен
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


        public void ShowLengh()
        {
            Console.WriteLine($"lenght = {this.Subjects.Length}");
        }

        public void AddItem(T item)// добавляет элемент в коллекцию
        {
            if (this.Subjects[0] == null)
            {
                this.Subjects = new T[1];
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
                ((IEnumerator)this).Reset();// reset

                return false;
            }
        }

        void IEnumerator.Reset() // реализация метода Reset() интерфеса IEnumerator
        {
            position = -1;
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
            if (this.Subjects.Length == 1)
            {

                return this.Subjects[0];

            }
            else
            {

                T buffItem = this.Subjects[0];

                T[] buffArr = new T[this.Subjects.Length - 1];

                for (int i = 0; i < buffArr.Length; i++)
                {
                    buffArr[i] = this.Subjects[i + 1];
                }

                this.Subjects = buffArr;

                return buffItem;
            }
        }

    }
}
