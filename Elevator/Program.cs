using System;
using System.Threading;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elevatorCab = new elevatorCab();

            Console.WriteLine($"Лифт на этаже: {elevatorCab.Stage}");

            Console.WriteLine($"Лифт находится в состоянии: {elevatorCab.Status.Ожидание}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Если вы планируете воспользоваться лифтом, то необходимо нажать кнопку вызова \"0\"");
            string key = Console.ReadLine();
            Console.WriteLine(new string('-', 30));
            
            if (Convert.ToInt32(key) == 0)
            {
                Console.WriteLine("Двери лифта открываются");
            }
            else 
            {
                Console.WriteLine("Двери лифта остаются закрытыми.");
                Thread.Sleep(1000);
                return;
            }

            Console.Write("Пожалуйста нажмите на кнопку этажа, на который хотите отправиться: ");
            string use = Console.ReadLine();
            Console.WriteLine(new string('-', 30));

            elevatorCab.goTO(Convert.ToInt32(use));
            if (Convert.ToInt32(use) > 20)
            {
                return;
            }
            Console.WriteLine(@"Лифт находится в состоянии: {0}", elevatorCab.status);
            Console.WriteLine(new string('-', 30));

            for (int i = 1; i < Convert.ToInt32(use); i++)
            {
                Console.WriteLine("Лифт находится на этаже: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Лифт на {0} этаже.", use);
            Console.WriteLine("Нажмите на кнопку \"0\" для открытия дверей.");
            Console.WriteLine(new string('-', 30));

            string door = Console.ReadLine();
            if (Convert.ToInt32(door) == 0)
            {
                Console.WriteLine($"{elevatorCab.Status.ОткрытиеДверей}, хорошего дня.");
            }
            else
            {
                Console.WriteLine($"{elevatorCab.Status.Блокировка}, ошибка! необходимо вызвать тех. поддержку.");
                Console.WriteLine("Ввведите на панеле номер: \"112\" для вызова тех. поддержки");
                string help = Console.ReadLine();
                if (Convert.ToInt32(help) == 112)
                {
                    Console.WriteLine("Тех. поддержка скоро доберётся, пожалуйста, подождите немного.");
                    for (int i = 0; i < 15; i++)
                    {
                        Console.WriteLine($"Пожалуйста ожидайте: {i}");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine($"{elevatorCab.Status.ОткрытиеДверей}, хорошего вам дня!");
                }
                else
                {
                    Console.WriteLine("Вы не справились, хорошего вам застрявшего в лифте дня!!!");
                    Thread.Sleep(1000);
                    return;
                }
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
