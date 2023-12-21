﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Eployee : People
    {
        protected int section;
        protected int workDay = 0;
        protected int workNight = 0;
        protected double salary;
        protected override void InfoIn()
        {
            base.InfoIn();
            string input;
            do
            {
                Console.WriteLine("Введите отдел (1 или 2): ");
                input = Console.ReadLine();
                if (input == "1")
                {
                    section = 1;
                }
                else if (input == "2")
                {
                    section = 2;
                }
                else
                {
                    Console.WriteLine("ОШИБКА!!! Такого отдела не существует\nНажмите Enter и попробуйте ещё раз . . .");
                    do
                    {
                        //Nothing
                    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    Console.Clear();
                    Console.WriteLine($"Имя: {name}");
                    Console.WriteLine($"Возраст (от 16 до 50): {age}");
                }
            } while (section != 1 && section != 2);
        }
        protected void Work()
        {
            Random random = new Random();
            workDay = random.Next(1, 31);
            if (age >= 18)
            {
                workNight = 30 - workDay;
            }
            salary = workDay * 2000 + workNight * 3500;    /*2000 - зарплата за одну дневную смену, 3500 - за одну ночную*/

        }
    }
}
