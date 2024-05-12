using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLessons1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;
           
            while (isOpen)
            {
                Console.SetCursorPosition(0,18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i+1} Свободно {sectors[i]} Мест.");

                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Регистрация рейса");
                Console.WriteLine("\n\n1 - Забронировать место\n\n2 - Выход из програмы\n\n");
                Console.Write("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaseAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine())-1;
                        if (sectors.Length <= userSector || userSector < 0) 
                        {
                            Console.WriteLine("Такого сектора не сушествует.");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать? ");
                        userPlaseAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaseAmount<0)
                        {
                            Console.WriteLine("Неверное количество мест.");
                            Console.WriteLine("Введите новые данные");
                            break;
                        }
                        if (sectors[userSector] < userPlaseAmount || userPlaseAmount<0)
                        {
                            Console.WriteLine($"В секторе :{userSector+1}: недостотаточно мест." +
                                $" Остаток {sectors[userSector]}" ) ;
                            break;
                        }
                        sectors[userSector] -= userPlaseAmount;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                    default:
                        break;
                }


                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
