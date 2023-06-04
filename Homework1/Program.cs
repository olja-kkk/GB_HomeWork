// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber < secondNumber) // Первое число меньше, второе = макс.
    Console.WriteLine ("Большее число: " + secondNumber + "; Меньшее число: " + firstNumber);

    else if (firstNumber > secondNumber) // Первое число больше, первое = макс.
    Console.WriteLine("Большее число: " + firstNumber + "; Меньшее число: " + secondNumber);

    else if (firstNumber == secondNumber) // equal numbers
    Console.WriteLine("Числа равны");

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

// max = a;
// if (b > a)
   // max = b;
// if (c > max)
 //    max = c;


/* 
Console.WriteLine("Input First number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > secondNumber & firstNumber > thirdNumber) // Первое число больше.
   Console.WriteLine("Большее число: " + firstNumber);

    else if (secondNumber > firstNumber & secondNumber > thirdNumber) // Второе число больше.
    Console.WriteLine("Большее число: " + secondNumber);

    else if (thirdNumber > secondNumber & thirdNumber > secondNumber) // Третье число больше.
    Console.WriteLine("Большее число: " + thirdNumber);
*/

// or

/*
Console.WriteLine("Input First number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

List<long> longs = new List<long> { firstNumber, secondNumber, thirdNumber };

long max = longs.Max();

Console.WriteLine("The largest number is {0}.", max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да

/* 
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

    if (x % 2 == 0)
    Console.WriteLine("Это четное число");

    else if (x % 2 == 1) 
    Console.WriteLine("Это нечетное число"); 

*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4

// Console.WriteLine("Input number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int evenNumber = 2;

//     while (evenNumber <= N)
//     {Console.WriteLine (evenNumber); 

//     evenNumber = evenNumber + 2;
//  }





// 
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
*/







   
    


    

