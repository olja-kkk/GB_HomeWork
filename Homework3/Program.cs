// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Input 5-digit Number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10000 && number <=99999)
// {
//     int firstDigit = (number / 10000); 
//     int secondDigit = (number / 1000) % 10;
//     int forthDigit = (number / 10) % 10;
//     int fifthDigit = number % 10;
//     if (firstDigit == fifthDigit && secondDigit == forthDigit)
//     {
//         Console.WriteLine("This is palindrome");
//     }
//     else
//     {
//       Console.WriteLine("This is not palindrome");
//     }
// }
// else 
// {
//     Console.WriteLine("The number should be 5-digit");
// }


// // Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("input x1 coordination: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input y1 coordination: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input z1 coordination: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input x2 coordination: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input y2 coordination: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input z2 coordination: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d =  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между точками: A:({x1},{y1}, {z1}) и B:({x2} ,{y2}, {z2}) равно: {Math.Round(d,2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t"); // i * i
//     // \t = Tab (1    2    3) 

// }


