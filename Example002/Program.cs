/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

Console.WriteLine("Введите точку b1: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку k1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку b2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку k2: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if (num==num2 & num1==num3) Console.WriteLine("Прямые совпадают");
else if (num1==num3) Console.WriteLine("Прямые параллельны друг другу");
else 
{
    x =(num2-num)/(num1-num3);
    y =num1*x+num;
    Console.WriteLine("точка пересечения "+" ("+ x+" ;"+y+ ")");
}
  
