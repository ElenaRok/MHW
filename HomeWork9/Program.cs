//Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.N = 4532 -> 4
/*int Amountnum (int N)
{
   if(N<=9)
    {
     return 1;
    }
    else return 1+ Amountnum(N/10);
}
Console.WriteLine( Amountnum(2507));// Цифра в скобках для примера.*/
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Sumnum( int M, int N)
{
    if(M==N)
    {
     return N;
        }
        else
        {
         return  N+ Sumnum(M,N-1);   
        }
}
 Console.WriteLine(Sumnum(3,5));