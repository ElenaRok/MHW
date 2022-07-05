/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Pal(int num)
{
  if (num>9999&& num>-100000)
  {
    Console.WriteLine("Число пятизначное"); 
  }
  else
  {
    Console.WriteLine("Укажите верное число"); 
  }
int num1= num/10000;
int num2= (num%10000)/1000;
int num4= (num%100-num%10)/10;
int num5= num%10;
if (num1==num5 && num2==num4)  
{
  Console.WriteLine("Число палиндром");  
} 
else
{
 Console.WriteLine("Число не палиндром");  
}   
}
Console.Write("Imput a number");
int num= Convert.ToInt32(Console.ReadLine());

Pal(num);
*/
/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kub(int N)
{
  int current=1;
  while (current<=N)
  {
   int result =(current*current *current);
   Console.WriteLine (""+ result);
   current++;
  }
  
 }
  Console.Write("Imput a number");
int N = Convert.ToInt32(Console.ReadLine());
Kub(N); 
*/