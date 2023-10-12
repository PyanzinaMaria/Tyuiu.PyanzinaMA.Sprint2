using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.PyanzinaMA.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Пьянзина М. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Пьянзина Мария Алексеевна | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: С начала 1990 года  *");
            Console.WriteLine("* по некоторый день прошло n месяцев и 2 дня. Определить название месяца  *");
            Console.WriteLine("* (январь, февраль и т.п.) этого дня.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int startYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сколько месяцев прошло: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res;
            if ((n < 1) || (n > 12))
            {
                res = "Месяц должен быть от 1 до 12.";
            }
            else
            {
                res = "Месяц: " + ds.FindMonthName(startYear, n);
            }
            Console.WriteLine($"С начала {startYear} года прошло " + n + " месяцев");
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}
