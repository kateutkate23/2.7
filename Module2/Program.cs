using System;
using static System.Console;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Уткина Екатерина Алексеевна";
            sbyte age = 18;
            string email = "kate_utkate@vk.com";
            double progPoints = 9.4;
            double mathPoints = 8.5;
            double physPoints = 3.7;

            string pattern = "ФИО: {0}\nВозраст: {1}\nПочта: {2}\nПрограммирование: {3}\nМатематика: {4}\nФизика: {5}";

            WriteLine(pattern, fullName, age, email, progPoints, mathPoints, physPoints);
            ReadKey();

            double total = progPoints + mathPoints + physPoints;
            double avg = total / 3;

            WriteLine($"Средний балл по трем предметам: {avg}");
            ReadKey();
        }
    }
}
