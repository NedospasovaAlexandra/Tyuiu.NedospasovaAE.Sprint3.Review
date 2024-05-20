using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint3.TaskReview.V5.Lib;

namespace Tyuiu.NedospasovaAE.Sprint3.TaskReview.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Тестирование по спринту                                           *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции, при этом  *");
            Console.WriteLine("* выполнить ряд условий                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine(" Старт шага: " + startValue);
            Console.WriteLine(" Конец шага: " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}
