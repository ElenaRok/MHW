

 /*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/
 /* Знаю, что неправильно, и в конце метод не вызван, но реально не хватает знаний по синтаксису с double*/

double[] Barray (double size)
{
  double[] newArray=new double[size];
  Console.WriteLine("Creating array here");
  for(double i =0; i<size; i++)
{
 Console.Write ($"Imput{i+1}elements:"); 
 newArray[i]= Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
return newArray;
}

void Carray(double[]array)
{
  for(double i=0; i<array.Length; i++)
  Console.Write (array[i] +"");
  Console.WriteLine();
}
  
void Earray(double[]array)
{
  double max=0;
  double min=0;
   for(double i=0; i<array.Length; i++);
 if(min<max) 
 Console.Write(max-min);
}
 Console.Write ("Imput size of orray:");
double size= Convert.ToDouble(Console.ReadLine());
Console.Write("Imput min of elements:");
double min= Convert.ToDouble(Console.ReadLine());
Console.Write ("Imput max of elements:");
double max= Convert.ToDouble(Console.ReadLine());
double []array= Barray(size);
Carray(array);
Console.WriteLine((max-min));

/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
 
int[] Aarray(int size, int min, int max)
{
  int [] newArray = new int [size];
  for (int i = 0; i < size; i++)
    newArray[i] =new Random().Next(100, 1000);
  return newArray;
}
void Carray(int[]array)
{
  for(int i=0;i<array.Length;i++)
  Console.Write (array[i]+"");
  Console.WriteLine();
}
int Darray (int[]array)
{
 int count=0;
  for (int i = 0; i <array.Length; i++)
if(array[i]% 2 == 0) count++;
{
  Console.WriteLine(""+count);
}

return count; 
}

Console.Write ("Imput size of orray:");
int size= Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput min of elements:");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput max of elements:");
int max= Convert.ToInt32(Console.ReadLine());

int[]array = Aarray( size,min, max);
Carray(array);
Console.WriteLine("count of positive" + Darray(array));*/

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] Aarray(int size, int min, int max)
{
  int [] newArray = new int [size];
  for (int i = 1; i < size; i++)
    newArray[i] =new Random().Next(min, max+1);
  return newArray;
}
void Carray(int[]array)
{
  for(int i=0;i<array.Length;i++)
  Console.Write (array[i]+"");
  Console.WriteLine();
}
int Farray (int[]array)
{
  int nsum =0;

for (int i = 1; i <array.Length; i+=2)
nsum+= array[i];
return nsum;
}
Console.Write ("Imput size of orray:");
int size= Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput min of elements:");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write ("Imput max of elements:");
int max= Convert.ToInt32(Console.ReadLine());

int []array= Aarray(size,min,max);
Carray(array);
Console.WriteLine("Сумма нечетных" + Farray(array));*/




