//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "6, 5, 4, 3, 2, 1"

// Console.WriteLine ("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(N, 1));

// //Метод

// string PrintNumbers(int start, int end){
// if (start==end) return start.ToString();
// return (start + " " + PrintNumbers(start - 1, end));
// }

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите число М");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число N");
// int N = int.Parse(Console.ReadLine()!);

// int sum (int M, int N)
// {
// if (M==N)
// return N;
// else return M + sum(M + 1, N);
// }
// Console.Write($"Сумма в промежутке от M до N: {sum(M,N)}");

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите значение m: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите значение n: ");
// int n = int.Parse(Console.ReadLine()!);

// int A(int m, int n)

// {
// if (m == 0) return n + 1;
// else if (n == 0) return A(m - 1, 1);
// else return A(m - 1, A(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {A(m, n)}");