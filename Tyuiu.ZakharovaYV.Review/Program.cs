using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ZakharovaYV.Review.Lib;

namespace Tyuiu.ZakharovaYV.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#5 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#5                                                                *");
            Console.WriteLine("* Тема: Итоговое решение по спринту                                       *");
            Console.WriteLine("* Задание # Review                                                        *");
            Console.WriteLine("* Вариант # 4                                                             *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все русские буквы на #.Полученный результат сохранить в файл   *");
            Console.WriteLine("* OutPutDataFileTask7V4.txt.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V4.txt";
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V4.txt";

            Console.WriteLine("Данные находятся в файле : " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находятся в файле : ");

            string w = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();

        }
    }
}
