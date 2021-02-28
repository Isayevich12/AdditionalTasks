using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdditionalTask3_UserCollectionQueueWithPriority
{
    class UserInteIrface
    {
        private static Car GenerateCar()
        {
            Console.WriteLine("Введите марку авто->");
            string model = Console.ReadLine();
            Console.WriteLine("Введите приоритет авто->");

            return int.TryParse(Console.ReadLine(), out int priority)? new Car(model, priority) : null  ;
        }

        public static void Run()
        {
            UserQueue<Car> carsQueue = new UserQueue<Car>();

            do
            {
                Console.Clear();

                Console.WriteLine("Приложение - пример пользовательской коллекции.\nОчередь прохождения Грузинской границы)))\n" +
                    "\tПосмотреть очередь->'look'\n\tДобавить машину->'add'\n\tПропустить через границу->'skip'");
              
                switch (Console.ReadLine())
                {
                    case "look":
                        {
                            foreach (Car item in carsQueue)
                            {
                                Console.WriteLine($"Марка->{item?.Name}\tПриоритет->{item?.Priority}");
                            }
                            break;
                        }
                    case "add":
                        {                        
                            Car car = GenerateCar();

                            if (car != null)
                            {
                                carsQueue.AddItem(car);
                            }
                            else
                            {
                                Console.WriteLine("Неверный ввод приоритета!!");
                            }
                            break;
                        }
                    case "skip":
                        {                          
                            carsQueue.ReleaseFistItem();

                            break;
                        }



                    default:
                        {
                            Console.WriteLine("Нет такого действи!!");
                            break;
                        }                     
                }

                Console.WriteLine(new string('_', 50));

                Console.WriteLine("Желаете продолжить? (Да-> 'y'   нет->  любой другой символ)");

            } while (Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase));



        }


    }
}
