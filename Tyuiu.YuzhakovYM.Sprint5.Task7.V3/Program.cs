using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YuzhakovYM.Sprint5.Task7.V3.Lib;
using System.IO;

namespace Tyuiu.YuzhakovYM.Sprint5.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Южаков Ю. М. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Южаков Юрий Михайлович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все русские буквы из файла.Полученный результат сохранить в     *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V3.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V3.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
