//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;

class Program
{
    static void ВывестиНатуральныеЧисла(int N)
    {
        if (N < 1)
        {
            // Базовый случай: если N стало меньше 1, завершаем рекурсию
            return;
        }

        Console.Write(N);

        if (N > 1)
        {
            Console.Write(", ");
        }

        // Рекурсивно вызываем функцию для числа N-1
        ВывестиНатуральныеЧисла(N - 1);
    }

    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Натуральные числа от " + N + " до 1: ");
        ВывестиНатуральныеЧисла(N);

        Console.WriteLine(); // Переходим на новую строку после вывода
    }
}


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


using System;

class Program
{
    static int НайтиСуммуНатуральныхЧисел(int M, int N)
    {
        if (M > N)
        {
            // Если M больше N, меняем их местами
            int временное = M;
            M = N;
            N = временное;
        }

        int сумма = 0;

        for (int i = M; i <= N; i++)
        {
            сумма += i;
        }

        return сумма;
    }

    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int сумма = НайтиСуммуНатуральныхЧисел(M, N);

        Console.WriteLine("Сумма натуральных чисел от " + M + " до " + N + " равна " + сумма);
    }
}



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


using System;

class Program
{
    static int Аккерман(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Аккерман(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Аккерман(m - 1, Аккерман(m, n - 1));
        }
        else
        {
            // Для отрицательных значений возвращаем -1 (не определено)
            return -1;
        }
    }

    static void Main()
    {
        int m1 = 2, n1 = 3;
        int m2 = 3, n2 = 2;

        int результат1 = Аккерман(m1, n1);
        int результат2 = Аккерман(m2, n2);

        Console.WriteLine("A(" + m1 + ", " + n1 + ") = " + результат1);
        Console.WriteLine("A(" + m2 + ", " + n2 + ") = " + результат2);
    }
}