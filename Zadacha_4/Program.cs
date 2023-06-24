/* **Задание 3:** Напишите программу, которая на вход принимает число, 
//и выдает, является ли это число четным (делится ли оно на два 
//без остатка).

Console.Clear();

Console.WriteLine("Программа определит, является ли введенное Вами число четным.");
Console.WriteLine("");

Console.Write("Введите целое число:  ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (number%2 == 0)
    {
        Console.WriteLine($"Вы ввели четное число: {number}");
        return;
    }
Console.WriteLine($"Вы ввели нечетное число: {number}");
Console.WriteLine(""); */

//**Задание 4:** Напишите программу, которая на вход принимает число (N), а на выходе
//все четные числа от 1 до N.
// -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Программа выведет,все четные числа от 1 до числа введенного Вами.");
Console.WriteLine("");

Console.Write("Введите целое число:  ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("");

int count = 1;
int sign = 1;// переменная для знака введенного числа

// На случай ввода отрицательных значений
if (number < 0)
    {
        sign = sign*-1;
    }

//На случай ввода -1, 0, 1
if (number >= -1 && number <=1 )
{
    Console.Write("В этом диапазоне нет четных чисел ");
    return;
} 

while (count <= Math.Abs(number))
{

if (count*sign%2 == 0)
    {
        Console.Write($"{count*sign}; ");
    }
count++;
}

Console.WriteLine("");