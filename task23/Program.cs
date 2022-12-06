// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int I =1;
int D = 0;

while (I <= N)
{
    D = I*I*I;
    I++;
    Console.WriteLine(D+" ");
}