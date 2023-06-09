// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray (int size, int minValue, int maxValue) // minv= 100, maxV = 999 

// {
//     int[] resultArray = new int[size];
    
//     for (int i = 0; i < resultArray.Length; i++)
//     {
//         resultArray[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return resultArray;
// }
// int[] array = GetArray(6, 100, 999);

// int evenNumber = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if ((array[i] % 2) == 0)
//     {
//         evenNumber++;
//         }
// }
// Console.WriteLine($"Array is: [ {String.Join("; " , array)} ]");
// Console.WriteLine($"Value of even numbers is: {evenNumber}");
    
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GetArray (int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];
    
//     for (int i = 0; i < resultArray.Length; i++)
//     {
//         resultArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return resultArray;
// }
// int[] array = GetArray(4, -100, 100);

// int sumOddPositions = 0;
// int i = 1;
// while (i < array.Length)
// {
//     sumOddPositions += array[i];
//     i = i + 2;
// }

// Console.WriteLine($"Array is: [ {String.Join("; " , array)} ]");
// Console.WriteLine($"Sum of elements on odd positions in array is: {sumOddPositions}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = new double[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round((new Random().NextDouble() * new Random().Next(1,101)),2);
// } 
// Console.WriteLine($"Array of real numbers: [ {String.Join("; ", array)} ]");

// double getValue (double minValue, double maxValue)
// {

// }
// int maxValue = ar.Max<int>();


