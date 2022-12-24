// Задача 42.
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void Number (int num)
{
    string count = "";
    while (num >= 1)
    {
        count = num % 2 + count;
        num = num / 2;
    }
    Console.WriteLine($"Двоичное представление введённого десятичного числа будет равно {count}");
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Number(n);
