// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// #nullable disable
// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = (number / 10) % 10;
// Console.WriteLine("Вторая цифра числа: " + secondDigit);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
    

Console.Write("Введите число больше 100: ");
if (int.TryParse(Console.ReadLine(), out int number) && number >= 100)
    {
        string strNumber = number.ToString(); // переводим введенное значение в строку
            if (strNumber.Length >= 3)
            {
                Console.WriteLine("Третий символ числа: " + strNumber[2]); // третий символ строки со вторым индексом
            }
            else
            {
                Console.WriteLine("Введено недостаточно символов.");
            }
        }
        else
        {
            Console.WriteLine("Введено некорректное значение.");
        }
        // Console.ReadLine();
    

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 1 -> нет

// #nullable disable 
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (number <= 7) // dayNumber < 1 || dayNumber > 7
// {
//    if (number == 6 || number == 7)
//    {
//     Console.WriteLine("It's a weekend!");
//    } 
//    else if (number <= 5 && number >= 1)
//    {
//     Console.WriteLine("It's not a weekend!");
//    } 
// break;
// }
// Console.WriteLine("Input number");

