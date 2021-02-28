using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_UserCollectionQueueWithPriority
{
    interface IPriority// пользовательский интерфейс . реализация его дает возможность попасть элементу в пользовательскую очередь
    {
        public int Priority { get; set; }

    }
}
