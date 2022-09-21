// Задайте значения N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
PrintNumber(number, count);
Console.Write(1);

void PrintNumber(int number, int count)
{
  if (count > number) return;
  PrintNumber(number, count + 1);
  Console.Write(count + ", ");
}