// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Enter the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number of coloumns: ");
// int coloumns = Convert.ToInt32(Console.ReadLine());
// double[,] resArray = GetArray(rows, coloumns);

// PrintArray(resArray);

// double[,] GetArray (int m, int n) // задаем 2d массив
// {
//     double[,] array = new double[m,n];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++) // цикл для всех ячеек памяти нулевой строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // цикл для всех столбцов нулевой строчки
//         {
//             array[i, j] = Math.Round((rnd.NextDouble() * 10),2);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] array2D) // печатаем 2Д массив, вводя НОВУЮ переменную - arrey2D
// {
//     for (int i = 0; i < array2D.GetLength(0); i++) //печать нулевой строки
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++) //печать нулевого столбца нулевой строки
//         {
//             Console.Write(array2D[i,j] + "\t"); // напечатает первую строчку
//         }
//         Console.WriteLine(); // просто напечатает вторую строчку - переход
//     }
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

// Console.Write("Enter the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] resArray = GetArray(rows, columns);

// PrintArray(resArray);

// Console.Write("Enter the position of the element (row): ");
// int rowIndex = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the position of the element (column): ");
// int columnIndex = Convert.ToInt32(Console.ReadLine());

// int positionValue = GetPositionByIndex(resArray, rowIndex, columnIndex);
// if (positionValue != -1)
//     {
//        Console.WriteLine("The value of element at position ({0}, {1}) is {2}", rowIndex, columnIndex, positionValue);
//     }
//     else
//     {
//         Console.WriteLine("There is no element at position ({0}, {1})", rowIndex, columnIndex);
//     }

// int[,] GetArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             Console.Write(array2D[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int GetPositionByIndex(int[,] array, int rowIndex, int columnIndex)
// {
//     if (rowIndex >= array.GetLength(0) || columnIndex >= array.GetLength(1))
//     {
//         return -1;
//     }
//     return array[rowIndex, columnIndex];
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Enter the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number of coloumns: ");
// int coloumns = Convert.ToInt32(Console.ReadLine());
// int[,] resArray = GetArray(rows, coloumns);

// PrintArray(resArray);
// Console.Write("Input the number of index: "); //сюда вставить еще, проверку на номер индекса и границу диапазона

// int[,] GetArray (int m, int n) // задаем 2d массив
// {
//     int[,] array = new int[m,n];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++) // цикл для всех ячеек памяти нулевой строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // цикл для всех столбцов нулевой строчки
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array2D) // печатаем 2Д массив, вводя НОВУЮ переменную - arrey2D
// {
//     for (int i = 0; i < array2D.GetLength(0); i++) //печать нулевой строки
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++) //печать нулевого столбца нулевой строки
//         {
//             Console.Write(array2D[i,j] + "\t"); // напечатает первую строчку
//         }
//         Console.WriteLine(); // просто напечатает вторую строчку - переход
//     }
// }

// void ValueArithmeticColumn(int[,] matr) // вводим метод, кот ищет ср. арифм.
// {
//     for (int i = 0; i < matr.GetLength(1); i++)  
//     {
//         double sum = 0; // вводим для среднего числа дробное знач. 
//         for (int j = 0; j < matr.GetLength(0); j++) 
//         {
            
//             sum = Math.Round((sum + matr[j, i]),2); // снач - j (столбец), и в нем все i
//         }
//         Console.WriteLine($"Среднее арифметическое значение элементов {i + 1} в столбце = {sum / matr.GetLength(0)}");
//     }
// }
// Console.WriteLine();
// ValueArithmeticColumn(resArray);

