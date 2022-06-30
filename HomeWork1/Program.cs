/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c, max; 

Console.Write("Imput a first number");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a third number");
c = Convert.ToInt32(Console.ReadLine());
max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("max =");
Console.WriteLine (max);
*/
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка
int n;
Console.Write("Imput a number");
n = Convert.ToInt32(Console.ReadLine());
if(n%2==0)
{
Console.WriteLine("n - четное");   
}
else
{
Console.WriteLine("n - нечетное");    
}
*/
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b;
Console.Write("Imput a first number");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number");
b = Convert.ToInt32(Console.ReadLine());
if(a<b)
{
Console.WriteLine("b - max, a -min");   
}
if(a>b)
{
Console.WriteLine("a - max, b -min");   
}
*/
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
*/int n, current;
Console.Write("Imput a number");
n = Convert.ToInt32(Console.ReadLine());
current=1;

while(current<n)
{
if (current%2==0) 
Console.WriteLine (current);
current++;
}




