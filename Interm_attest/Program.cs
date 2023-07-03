// Урок 9. Рекурсия

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Input N number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// /// <summary>
// /// printing numbers from 1 to N
// /// </summary>
// /// <param name="start"> левая граница (1) </param>
// /// <param name="end"> правая граница (число N) </param>
// /// <returns> метод вернет строчку с результатами от 1 до N </returns>
// string GetStringOfNumbers(int end, int start)
// {
// // 1. base case - exit 
// if (end == start) return end.ToString(); // конвертировали последнее число в формате строки, 
// // тк надо в итоге вывести строку, потому что в задаче ЗАПЯТЫЕ!!!

// // 2. recursion
// return end + " , " + GetStringOfNumbers(end -1, start);
// }
// Console.WriteLine(GetStringOfNumbers(N, 1)); // start = 1, end - N OR 


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Input M number: ");
// int m = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
// Console.Write("Input N number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// /// <summary>
// /// printing SUM of elements between 1 to N
// /// </summary>
// /// <param name="M"> first number to count</param>
// /// <param name="N"> last number to count </param>
// /// <returns> returns sum of elements from N to M </returns>
// int sum = GetSumOfElements(m, n);
// Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");

// int GetSumOfElements(int N, int M) 
// {
//     if (N == M) 
//     return N;
//     return N + GetSumOfElements(N + 1, M);
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//         {
//         return Ackermann(m - 1, 1);
//         }
//     else
//         {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
// }

// {
//     int m = 2;
//     int n = 3;
//     int result = Ackermann(m, n);

//     Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

//     m = 3;
//     n = 2;
//     result = Ackermann(m, n);

//     Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
// }


