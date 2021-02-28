using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_UserCollectionQueueWithPriority
{
    class Car : IPriority// тестовый класс для работы с пользовательской очередью
    {
        public string Name { get; set; }
        public int Priority { get; set; }

        public Car(string name, int priority)
        {
            this.Name = name;
            this.Priority = priority;
        }

        public Car()
        {
            this.Name = "zepor";
            this.Priority = 0;
        }

    }
}
