/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int Tunumber()
{
int num = new Random().Next(100,1000);
Console.WriteLine ("Current random number is" + num);
int Sotni=num%100;
int result= Sotni/10;
return result;
}
int number = Tunumber();
Console.WriteLine("Result number is" + number);
/*

Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
/*int Anumber (int num)
{
if (num<100&& num>-100)
{
    Console.WriteLine("Число не имеет 3-ю цифру");
}
else
{
   Console.WriteLine("Число имеет 3-ю цифру");
}
}
int result = Anumber(int num);
return result;
 Console.Write("Imput a number");
 int num = Convert.ToInt32(Console.ReadLine());

int current=num;
while (current>99&& current<-999) 
{
  current =current%10;
  Console.Write(current+"");
  current++;
}


Console.Write(current);


/*( Всё из до чего дошла умом перепробовала, не получается вывести из цикла 3-ю цифру:())



/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Bnumber()
{
    Console.Write("imput a number ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num==1)
    {
     Console.WriteLine ("Понедельник");   
    }
    if (num==2)
    {
     Console.WriteLine ("Вторник");   
    }
    if (num==3)
    {
     Console.WriteLine ("Среда");   
    }
    if (num==4)
    {
     Console.WriteLine ("Четверг");   
    }
    if (num==5)
    {
     Console.WriteLine ("Пятница");   
    }
    if (num==6)
    {
     Console.WriteLine ("Суббота -выходной");   
    }
    if (num==7)
    {
     Console.WriteLine ("Воскресенье -выходной");   
    }
    if (num>7||num<1)
    {
     Console.WriteLine ("Приветствую тебя, потомок майя!");   
    }
}Bnumber();
*/






