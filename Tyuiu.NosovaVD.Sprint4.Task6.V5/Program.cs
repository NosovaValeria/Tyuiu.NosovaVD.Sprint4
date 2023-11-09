using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosovaVD.Sprint4.Task6.V5.Lib;
namespace Tyuiu.NosovaVD.Sprint4.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Носова В.Д. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Носова Валерия Дмитриевна | ПКТб-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Меркурий\", \"Венера\", \"Земля\",             *");
            Console.WriteLine("* \"Марс\", \"Юпитер\", \"Сатурн\", \"Уран\", \"Нептун\"] используя класс           *");
            Console.WriteLine("* Array подсчитайте количество элементов, длина которых равна 5.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var planets = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < planets.Length-1; i++)
            {
                 Console.WriteLine(planets[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(planets));
            Console.ReadKey();
        }
    }
}
