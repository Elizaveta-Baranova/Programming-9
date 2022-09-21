// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = ReadInt ("Введите число M: ");
int N = ReadInt ("Введите число N: ");

int SumNumbers(int M, int N)
{
    if (N > M)
        return N + SumNumbers(M, N - 1);
    return M;
}
int result = SumNumbers (M, N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {result}.");

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}