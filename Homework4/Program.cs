// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Input A digit: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B digit: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int degree = 1;
// for (int i = 1; i <= b; i++)
// {
//     degree = degree * a;
// }

// Console.WriteLine($"Value {a} in power of {b} is: {degree}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (number > 0)
// {
//     sum = sum + number % 10; // получаем последнюю цифру и добавляем её к сумме
//     number = number / 10;      // убираем последнюю цифру из числа
// }

// Console.WriteLine($"Sum of digits in number {number} is: {sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Input number: ");
// int size = 8;
// int[] array = new int [size];

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(0 , 8);
// }
// Console.WriteLine($"Array: [ {String.Join(";", array)} ]");


