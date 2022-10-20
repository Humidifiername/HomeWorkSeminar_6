// Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь

Console.Write("Пользователь ввел M чисел");
int[] M = new int[50];

for (int i = 0; i < M.Length; i++)
{
    M[i] = new Random().Next(-100, 101);
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < M.Length; i++)
{
    Console.Write($"{M[i]} ");
}

for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел > 0 = {count}");

// Задча 43
// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, k2, b2 задаются пользователем.

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = -(b1 - b2) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых = {x}, {y}");
