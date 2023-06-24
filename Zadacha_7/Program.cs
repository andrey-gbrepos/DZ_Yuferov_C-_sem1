/* Задача 7
Напишите программу, которая принимает на вход трехзначное число и  
на выходе показывает**последнюю** цифру этого числа.*/

Console.Clear();
Console.Write("Введите трехзначное целое число:  ");
int num_3value = int.Parse(Console.ReadLine());

if (num_3value < 100 || num_3value > 999)
    
    {
    Console.WriteLine("Это не трехзначное целое число ( ");
    Console.Write("До свидания!");
    
    return;
    }

    int y=num_3value%10;

    Console.WriteLine($"Последняя цифра Вашего числа -> {num_3value%10}");
   
