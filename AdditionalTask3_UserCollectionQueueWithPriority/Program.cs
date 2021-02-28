using System;

namespace AdditionalTask3_UserCollectionQueueWithPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            // просто пример реализации пользовательской очереди

            Car car1 = new Car("bmv", 3);
            Car car2 = new Car("mers", 2);
            Car car3 = new Car("priora", 1);
            Car car4 = new Car("Buldozer", 0);

            UserQueue<Car> park = new UserQueue<Car>();
            park.AddItem(car1);
            park.AddItem(car2);
            park.AddItem(car3);
            park.AddItem(car4);
            foreach (Car item in park)
            {
                Console.WriteLine($"Марка машны : {item?.Name}\tПриоритет : {item?.Priority}");
            }
            Console.WriteLine(park.LenghtQueue);

            Console.WriteLine(park[1].Name);


            Console.WriteLine(new string('_', 50));

            park.ReleaseFistItem();

            foreach (Car item in park)
            {
                Console.WriteLine($"Марка машны : {item?.Name}\tПриоритет : {item?.Priority}");
            }
        }
    }
}
