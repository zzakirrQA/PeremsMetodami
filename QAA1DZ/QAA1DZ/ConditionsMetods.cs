using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA1DZ
{
    internal class ConditionsMetods
    {
        public static int ComparisonAandB(int a,int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a < b)
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
        }

        public static string PointinCoordinate(int x,int y)
        {
            if (x > 0 && y > 0)
            {
                return "1ая четверть";
            }
            else if (x > 0 && y < 0)
            {
                return "2ая четверть";
            }
            else if (x < 0 && y < 0)
            {
                 return "3ая четверть";
            }
            else if (x < 0 && y < 0)
            {
                return "4ая четверть";
            }
            else
            {
                return "точка находится на оси";
            }
        }

        public static void DvuzCisloPropisnoy(int number)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("десять");
                    break;
                case 11:
                    Console.WriteLine("одиннадцать");
                    break;
                case 12:
                    Console.WriteLine("двенадцать");
                    break;
                case 13:
                    Console.WriteLine("тринадцать");
                    break;
                case 14:
                    Console.WriteLine("четырнадцать");
                    break;
                case 15:
                    Console.WriteLine("пятнадцать");
                    break;
                case 16:
                    Console.WriteLine("шестнадцать");
                    break;
                case 17:
                    Console.WriteLine("семнадцать");
                    break;
                case 18:
                    Console.WriteLine("восемнадцать");
                    break;
                case 19:
                    Console.WriteLine("девяднатцать");
                    break;
            }

            switch (number / 10)
            {
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятдесять ");
                    break;
                case 6:
                    Console.Write("шестдесять ");
                    break;
                case 7:
                    Console.Write("семдесять ");
                    break;
                case 8:
                    Console.Write("восемьдесять ");
                    break;
                case 9:
                    Console.Write("девяноста ");
                    break;
            }
            switch (number % 10)
            {
                case 1:
                    Console.WriteLine("один ");
                    break;
                case 2:
                    Console.WriteLine("два ");
                    break;
                case 3:
                    Console.WriteLine("три ");
                    break;
                case 4:
                    Console.WriteLine("четыре ");
                    break;
                case 5:
                    Console.WriteLine("пять ");
                    break;
                case 6:
                    Console.WriteLine("шесть ");
                    break;
                case 7:
                    Console.WriteLine("семь ");
                    break;
                case 8:
                    Console.WriteLine("восемь ");
                    break;
                case 9:
                    Console.WriteLine("девять ");
                    break;
            }

        }

    }
}
