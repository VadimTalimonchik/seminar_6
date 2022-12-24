// Задача 44.
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

string Fibon (int N)
{
   string C = ($"N = {N} -> 0 1 ");
   int sum = 0;
   int N1 = 0;
   int N2 = 1;
   int i = 2;

   while (i < N)
   {
      sum = N1 + N2;
      C = C + sum + " ";
      N1 = N2;
      N2 = sum;
      i++;
   }
   return C;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Fibon(N));



// // Вариант 2
// void MetFib(int Num)
// {
//    int[] listFib = new int[Num];
//    Console.Write(listFib[0]);
//    listFib[1] = 1; Console.Write(listFib[1]);
//    for (int i = 2; i < Num; i++)
//    {
//       listFib[i] = listFib[i-1]+listFib[i-2];
//       Console.Write(listFib[i]);
//    }
// }
// int num = int.Parse(Console.ReadLine()!);
// MetFib(num);

