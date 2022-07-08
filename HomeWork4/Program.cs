/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumber(int num)
{
 int Sum=0;
  while (num>0)
  {
   Sum = Sum+num%10;
 num= num/10;
  }
    return Sum;
}
Console.Write("Imput a number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumber(num));
 *//*Напишите программу, которая задаёт массив из m элементов и выводит их на экран.*/
 
int[] Aarray(int size, int min, int max)
{
  int [] newArray = new int [size];
  for (int i = 0; i < size; i++)
    newArray[i] =new Random().Next(min, max +1);
  return newArray;
}

/*int [] Barray (int size)
{
  int[] newArray=new int[size];
  Console.WriteLine("Creating array here");
  for(int i =0; i<size; i++)
{
 Console.Write ($"Imput{i+1}elements:"); 
 newArray[i]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
return newArray;
}В решении этой задачи закоментированный метод для красоты)
*/ 

void Carray(int[]array)
{
  for(int i=0;i<array.Length;i++)
  Console.Write (array[i]+"");
  Console.WriteLine();
}
Console.Write ("Imput size=m of orray:");
int msize= Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput min of elements:");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput max of elements:");
int max= Convert.ToInt32(Console.ReadLine());
int[]array1=Aarray(msize, min, max);
Carray(array1);


