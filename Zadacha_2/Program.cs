
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число А");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число B");
int b=Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("Число А является большим чем B");
} 
else
{
    Console.WriteLine("Число B является большим чем A");
}