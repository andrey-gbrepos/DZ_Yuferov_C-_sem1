//Задача 8: Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
//**Задание 4:** Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все четные числа от 1 до N.
// -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Программа выведет,все четные числа от 1 до числа N введенного Вами.");
Console.WriteLine("");

Console.Write("Введите натуральное число:  ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("");

int count = 1;


// На случай ввода отрицательных значений
if (number < 0)
    {
       Console.WriteLine($"Отрицательное значение.");
       Console.WriteLine($"Перезапустите программу, введите натуральное число.");
       return;
    }

//На случай ввода 0
if (number == 0 )
{
    Console.Write($"Четные значения дипазона: {0}");
    return;
} 
Console.Write($"Четные значения диапазона: ");

while (count <= Math.Abs(number))
{

if (count%2 == 0)
    {
        Console.Write($"{count}; ");
    }
count++;
}

Console.WriteLine("");