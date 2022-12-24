// Задача 40.
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// (Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон)
// a < b + c
// b < a + c
// c < a + b

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine()!);

void Triangle (int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Существует!");
    }
    else
    {
        Console.WriteLine("Не существует!");
    }
}
Triangle(5, 4, 8);
