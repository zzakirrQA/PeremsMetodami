using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA1DZ
{
    internal class PeremMetodi
    {
        public static void ResultRemaindDivision(int a, int b)
        {
            Console.WriteLine($"Число {a} деленный на число {b} равно {a / b}");
            Console.WriteLine($"Остаток от числа {a} при делении на число {b} равно {a % b}");
        }

        public static double ResultDivisionExpression(int a,int b)
        {
            double result = (5 * a + b * b) / (b - a);

            return result;
          
        }

        public static double ResultLinearEquation(int a,int b,int c)
        {
            Console.WriteLine($"уравнение имеет вид: {a}x + {b} = {c}");
            double X = (c - b) / a;
            Console.Write($"значение х равен: ");
            return X;
        }

         public static string FindEquationStraight(int x1,int y1,int x2, int y2)
        {
            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;
            return $"Уравнение имеет вид: Y = {a}X + {b}";
        }
    }
}
