using QAA1DZ;
#region Переменные_1
//Пользователь вводит 2 числа (A и B).
//Выведите в консоль результат деления A на B и остаток от деления

/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} деленный на число {b} равно { a / b}");
Console.WriteLine($"Остаток от числа {a} при делении на число {b} равно { a % b}");*/

//с помощбю методов
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

PeremMetodi.ResultRemaindDivision(a, b);*/

#endregion
#region Переменные_2
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double result = (5 * a + b * b) / (b - a);
Console.WriteLine(result);*/

//с помошью методов
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

double result = PeremMetodi.ResultDivisionExpression(a, b);
Console.WriteLine(result);*/

#endregion
#region Переменные_3
//*Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте
//содержимое переменных A и B местами.

/*string a = Console.ReadLine();
string b = Console.ReadLine();
string c;
c = a;
a = b;
b = c;
Console.WriteLine(a);
Console.WriteLine(b);*/
#endregion
#region Переменные_4
/*Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль
решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.*/

/*Console.WriteLine("введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число c:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"уравнение имеет вид: {a}x + {b} = {c}");
double X = (c - b) / a;
Console.WriteLine($"значение х равен: {X}");*/

//с помощью методов

/*Console.WriteLine("введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число c:");
int c = Convert.ToInt32(Console.ReadLine());

double result = PeremMetodi.ResultLinearEquation(a, b, c);
Console.WriteLine(result);
*/
#endregion
#region Переменные_5
/* *Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х
точек на координатной плоскости. Выведите уравнение прямой в формате
Y=AX+B, проходящей через эти точки.*/

/*Console.WriteLine("введите координаты первой точки х1 и у1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты второй точки х2 и у2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double a = (y2 - y1) / (x2 - x1);
double b = y1 - a * x1;
Console.WriteLine($"Уравнение имеет вид: Y = {a}X + {b}");*/

//с помощью методов

/*Console.WriteLine("введите координаты первой точки х1 и у1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты второй точки х2 и у2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

string result =  PeremMetodi.FindEquationStraight(x1,y1,x2,y2);
Console.WriteLine(result);
*/
#endregion



#region СтруктВетв_1
/*Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B,
подсчитать A*B, если A<B, подсчитать A-B.*/

/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a + b);
}
else if (a < b)
{
    Console.WriteLine(a - b);
}
else
{
    Console.WriteLine(a * b);
}*/

//с помощью методов

/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = ConditionsMetods.ComparisonAandB(a, b);
Console.WriteLine(result);*/

#endregion
#region СтруктВетв_2
/*Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит
точка с координатами (X,Y).*/
/*Console.WriteLine("введите координаты точки:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("1ая четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("2ая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3ая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("4ая четверть");
}
else
{
    Console.WriteLine("точка находится на оси");

}*/

//с помозью методов

/*int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

string result = ConditionsMetods.PointinCoordinate(x, y);
Console.WriteLine(result);*/
#endregion
#region СтпуктВетв_3
/**Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке
возрастания.*/

/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int min;
int x;
int y;

if (a <= b && a <= c)
{
    min = a;
    x = b;
    y = c;
}

else if (b <= a && b <= c)
{
    min=b;
    x = a;
    y = c;  
}

else
{
    min = c;
    x = a;
    y = b;
}
if(x<y)
{
    Console.WriteLine($"{min} {x} {y}");
}
else
{
    Console.WriteLine($"{min} {y} {x}");
}
*/
#endregion
#region СтруктВетв_4
/**Пользователь вводит 3 числа (A, B и С). Выведите в консоль
решение(значения X) квадратного уравнения стандартного вида, где
AX^2 + BX + C = 0  */

/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"уравнение имеет вид {a}x^2 + ({b})x + ({c}) = 0");

double diskrim = b * b - 4 * a * c;
if (diskrim > 0)
{
    double x1 = (-b + Math.Sqrt(diskrim)) / 2 * a;
    double x2 = (-b - Math.Sqrt(diskrim)) / 2 * a;
    Console.WriteLine($"первый корень равен {x1}");
    Console.WriteLine($"второй корень равен {x2}");


}
else if (diskrim == 0)
{
    double x = -b / 2 * a;
    Console.WriteLine($"имеет только один корень который равен {x}");

}
else
    Console.WriteLine($" не имеет корня!!");
*/
#endregion
#region СтруктВетв_5
/*Пользователь вводит двузначное число. Выведите в консоль прописную
запись этого числа. Например при вводе “25” в консоль будет выведено
“двадцать пять”.*/

/*int number = Convert.ToInt32(Console.ReadLine());
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

*/

//с помощью методов

/*int number = Convert.ToInt32(Console.ReadLine());
ConditionsMetods.DvuzCisloPropisnoy(number);*/

#endregion
#region СтруктВетв_6
/*6.Определить, попадает ли точка M(x,y) в круг радиусом r с центром в точке (x0,y0)
*/

/*int Mx = Convert.ToInt32(Console.ReadLine());
int My = Convert.ToInt32(Console.ReadLine());
int radius = Convert.ToInt32(Console.ReadLine());
int x0 = 0;
int y0 = 0;
double dlina = Math.Sqrt((Mx - x0) * (Mx - x0) + (My - y0) * (My - y0));
if (dlina < radius)
    Console.WriteLine("точка находится в круге");
else if (dlina > radius)
    Console.WriteLine("точка не находится в круге");
else
    Console.WriteLine("точка находиться в окружности");*/

#endregion
#region СтруктВетв_7.1
/* квадрат заданного трехзначного числа равен кубу суммы цифр этого числа;
*/

/*int number = Convert.ToInt32(Console.ReadLine());
int kvad = number * number;
int sumCifr = (number % 10) + (number / 10 % 10) + (number / 100);
int kub = sumCifr * sumCifr * sumCifr;
if (kub == kvad)
    Console.WriteLine(true);
else
    Console.WriteLine(false);*/
#endregion
#region СтруктВетв_7.2
/*сумма двух первых цифр заданного четырехзначного числа равна сумме двух его последних цифр;
*/

/*int number = Convert.ToInt32(Console.ReadLine());
int sumPerv = (number/1000) + (number/100%10);
int sumPosl = (number / 10 % 10) + (number % 10);
if (sumPerv == sumPosl)
    Console.WriteLine(true);
else
    Console.WriteLine(false); 
*/
#endregion
#region СтруктВетв_7.3
/*среди цифр заданного трехзначного числа есть одинаковые;
*/

/*int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 100;
int num2 = number / 10 % 10;
int num3 = number % 10;
if (num1 != num2 && num1 != num3 && num2 != num3)
    Console.WriteLine(false);
else
    Console.WriteLine(true);*/
#endregion
#region СтруктВетв_7.4
/*среди первых трех цифр из дробной части заданного положительного 
вещественного числа есть цифра 0.*/

/*double num = Convert.ToDouble(Console.ReadLine());
int newNumb = Convert.ToInt32(num * 1000);
Console.WriteLine(newNumb);
if (newNumb / 100 % 10 == 0)
    Console.WriteLine(true);
else if (newNumb / 10 % 10 == 0)
    Console.WriteLine(true);
else if (newNumb % 10 == 0)
    Console.WriteLine(true);
else
    Console.WriteLine(false);*/


#endregion















