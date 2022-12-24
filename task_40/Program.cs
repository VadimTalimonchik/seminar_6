// Задача 40.
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// (Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон)
// a < b + c
// b < a + c
// c < a + b

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

void Triangle (int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Треугольник с такими сторонами Существует!");
    }
    else
    {
        Console.WriteLine("Треугольник с такими сторонами Не существует!");
    }
}
Triangle(a, b, c);

// Triangle(5, 4, 8);

// // Вариант 2

// bool Triangle (int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     else return false;
// }
// Console.WriteLine(Triangle(5, 4, 8));
