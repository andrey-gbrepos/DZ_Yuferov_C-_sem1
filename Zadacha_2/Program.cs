/* **Залание 1:** Напишите программу, которая на вход принимает 
два числа, и выдает какое число больше, а какое меньше.

a = 5;  b = 7  -> max = 7 

Console.Clear();
Console.WriteLine("Программа определит, какое из двух чисел, веденных Вами больше.");
Console.WriteLine("");

Console.Write("Введите первое число:  ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Введите второе число:  ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine($"Вы ввели: {num1} и {num2}");

if (num1 < num2)
    {
    Console.WriteLine($"Наибольшее число из них {num2}");
    Console.WriteLine("");
    
    return;
    }
if (num1 > num2)
    
    {
    Console.WriteLine($"Наибольшее число из них {num1}");
    
    return;
    }

Console.WriteLine($"Введенные числа равны {num1} = {num2}"); */

/* **Залание 2:** Напишите программу, которая  принимает на вход 
три числа, и выдает максимальное из этих чисел. */
 
//2, 3, 7 -> 7 */

Console.Clear();
Console.WriteLine("Программа определит, какое из трех чисел, веденных Вами больше.");
Console.WriteLine("");

Console.Write("Введите первое число:  ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Введите второе число:  ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Введите третье число:  ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine($"Вы ввели: {num1}, {num2}, {num3}");

int max = num1;

if (max < num2)
    {
        max = num2;
    }
if (max < num3)   
    {
        max = num3;
    }

Console.WriteLine($"Максимальное число из введенныx Вами {max}");
Console.WriteLine("");