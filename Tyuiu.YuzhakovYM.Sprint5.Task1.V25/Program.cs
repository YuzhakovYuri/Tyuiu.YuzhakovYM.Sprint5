using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YuzhakovYM.Sprint5.Task1.V25.Lib;

namespace Tyuiu.YuzhakovYM.Sprint5.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Южаков Ю. М. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Южаков Юрий Михайлович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция,F(x) = (2sin(x)/(3x+1,2))+cos(x)-7x*2 (произвести          *");
            Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести  *");
            Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.       *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на   *");
            Console.WriteLine("* консоль в таблицу. Значения округлить до двух знаков после запятой.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
