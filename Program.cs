// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void VerificationNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число является палиндромом.");
  }
  else Console.WriteLine($"Ваше число НЕ палиндром.");
}

if (number!.Length == 5)
{
  VerificationNumber(number);
}
else Console.WriteLine($"Введи правильное число");

//=============================================================================================================================================================================================


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
System.Console.Write("Введите координкту x первой точки: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);
System.Console.Write("Введите координкту y первой точки: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);
System.Console.Write("Введите координкту x первой точки: ");
bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);


System.Console.Write("Введите координкту x второй точки: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);
System.Console.Write("Введите координкту y второй точки: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);
System.Console.Write("Введите координкту x второй точки: ");
bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);


if(!isNumberX_1 || !isNumberX_2 || !isNumberY_1 || !isNumberY_2 || !isNumberZ_1 || !isNumberZ_2)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}

System.Console.Write($"Расстояние: {GetLenght(x1,y1,z1,x2,y2,z2)}");

double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
*/
//=====================================================================================================================================================================


// Задача 23 Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125
/*
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.Write("Введите первое число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int M = Convert.ToInt32(Console.ReadLine());
            for (int i = N; i <= M; i++)
            {
                double j = Math.Pow(i, 3);
                Console.Write($"<{j}> ");
            }
        }
    }
}

*/
//-------------------------------------------------------------------------------------------------------


// Задача 23 Бонус 
//Введите число и программа возведет его в куб.
/*
Console.WriteLine($"Введите число и нажми на enter для того чтобы программа возвела его в куб!");
string number = Console.ReadLine();
int x = Convert.ToInt32(number);
Console.WriteLine(Math.Pow(x, 3));
while (Console.ReadKey().Key != ConsoleKey.Enter) { }
*/


