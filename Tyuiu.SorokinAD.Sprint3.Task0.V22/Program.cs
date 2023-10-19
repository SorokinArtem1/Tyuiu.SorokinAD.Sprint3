﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint3.Task0.V22.Lib;

namespace Tyuiu.SorokinAD.Sprint3.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

             Console.Title = "Спринт #3| Выполнил: Сорокин А. Д. | ИИПб-23-2";
             Console.WriteLine("***************************************************************************");
             Console.WriteLine("* Спринт #3                                                               *");
             Console.WriteLine("* Тема: Оператор цикла for                                                *");
             Console.WriteLine("* Задание #0                                                              *");
             Console.WriteLine("* Вариант #22                                                             *");
             Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
             Console.WriteLine("***************************************************************************");
             Console.WriteLine("* УСЛОВИЕ:                                                                *");
             Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
             Console.WriteLine("* произведение ряда по формуле, при a = 0,25                              *");
             Console.WriteLine("*                                                                         *");
             Console.WriteLine("***************************************************************************");
             Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
             Console.WriteLine("***************************************************************************");

             double value = 0.25;
             int startValue = 1;
             int stopValue = 8;
             Console.WriteLine($"Переменная a = {value}");
             Console.WriteLine($"Старт шага = {startValue}");
             Console.WriteLine($"Конец шага = {stopValue}");


             Console.WriteLine("***************************************************************************");
             Console.WriteLine("* Резльтат                                                                *");
             Console.WriteLine("***************************************************************************");

             Console.WriteLine($"Сумма рада = {ds.GetMultiplySeries(value, startValue, stopValue)}");

             Console.ReadKey(); 




        }
    }
}
