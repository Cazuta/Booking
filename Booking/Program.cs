using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sector = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sector.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sector[i]}");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регестрация рейса. ");
                Console.WriteLine("\n\n1 - забронировать места\n\n 2 - выход из команды\n\n ");
                Console.Write("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sector.Length <= userSector || userSector < 0)

                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Введено неверное количество мест. ");
                            break;
                        }
                        if (sector[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($" В секторe {userSector + 1} недостаточно мест. Остаток {sector[userSector]}");
                            break;
                        }
                        sector[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронировоние завершено успешно");
                        break;


                    case 2:
                        isOpen = false;
                        break;
                }


                Console.ReadKey();
                Console.Clear();

            }















        }
    }
}
