// Разбор рекурсии:

// int rec(int n)
// {
//     if (n == 0)
//     {
//         Console.WriteLine("Это конец рекурсии!");
//         return 0;
//     }

//     int result = 0;
//     result = n + n + 8;
//     Console.WriteLine("Это рекурсия!");

//     return result + rec(n - 1);
// }

// Разбор рекурсии 2:

// int rec(int n)
// {
//     if (n == 0)
//     {
//         Console.WriteLine("Это конец рекурсии!");
//         return 1;
//     }


//     Console.WriteLine("Это рекурсия!");

//     return 2 * rec(n - 1);
// }

// Console.WriteLine("Результат рекурсии: " + rec(10));


// Console.WriteLine("Результат рекурсии: " + rec(10));




// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6" 

// void PrintNumbers(int n)
// {
//     if (n == 0)
//     {
//         return;
//     }
//     PrintNumbers(n - 1); // 4, 3, 2, 1
//     Console.Write(n + " "); // 5, 4, 3, 2, 1
// }

// PrintNumbers(5);


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8"

// void PrintNumbers(int M, int N)
// {
//     if (M > N)
//     {
//         Console.WriteLine("Конец рекурсии!");
//         return;
//     }
//     Console.Write(M + " "); // 2 , 3, 4, 5
//     PrintNumbers(M + 1, N); // 3 , 4, 5, 
// }  
// PrintNumbers(2, 5);


// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 
// 45 -> 9 

// Console.WriteLine("Введите число n: ");
// int n = int.Parse(Console.ReadLine());
// int rec(int n)
// {
//     if (n == 0)
//     {
//         Console.WriteLine("Это конец рекурсии!");
//         return 0;
//     }
//     return n % 10 + rec(n / 10); // 123: 3+2+1
// }

// Console.WriteLine("Результат рекурсии:" + rec(n));


// Задача 69: Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B с 
// помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) 
// A = 2; B = 3 -> 8

// Console.WriteLine("Введите число А: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = int.Parse(Console.ReadLine());
// int rec(int A, int B)
// {
//     if (B == 0)
//     {
//         Console.WriteLine("Это конец рекурсии!");
//         return 1;
//     }

//     return A * rec(A, B - 1);
// }

// Console.WriteLine("Результат рекурсии:" + rec(A, B));
