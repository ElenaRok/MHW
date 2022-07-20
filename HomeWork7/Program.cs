
 /*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 

Console.Write("Imput number of rows:");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns:");
int n= Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"m={m}, n={n}.");
double[,] array = new double [m,n];
A2array(array);
C2array(array);
Console.WriteLine();


void A2array( double[,]array)

{
    for(int i=0; i<m; i++)
    {
    for(int j=0; j<n;j++)
    {
      array[i,j]= new Random().NextDouble ()* 20-10;
    }
}
}

void C2array(double [,]array)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        double Nam= Math.Round (array[i,j]++);
        Console.WriteLine(Nam +"");
    }
    Console.WriteLine();
}
}
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*//*
Console.Write("Imput number of rows:");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns:");
int n= Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"m={m}, n={n}.");
double[,] array = new double [m,n];
A2array(array);
C2array(array);
Console.WriteLine();


void A2array( double[,]array)

{
    for(int i=0; i<m; i++)
    {
    for(int j=0; j<n;j++)
    {
      array[i,j]= new Random().NextDouble ()* 20-10;
    }
}
}

void C2array(double [,]array)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        double Nam= Math.Round (array[i,j]++);
        Console.WriteLine(Nam +"");
    }
    Console.WriteLine();
}
}
	

int[,] MidArith = new int[m, n];

Console.Write("Middle arithmetik");
for (int i = 0; i < n; i++)
{
  double arithmetic= 0;
  for (int j = 0; j < m; j++)
  {
    arithmetic += MidArith[j, i];
  }
  arithmetic = Math.Round(arithmetic / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmetic}");
}


int[,] Wed (double[,] array)
{
  int[,] MMidArith = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      MidArith[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return MidArith;
}


void Show(int[,] MidArith)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(MidArith[i, j] + " ");
      }
      Console.WriteLine();
  }
}

MidArith = Wed(array);
Show(MidArith);*/
// Задачи выполнены с коллективным разумом. Третью задачу не стала так выполнить(
// Синтаксис в вещественных задачах, откровенно хромает на обе ноги...
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.	
int [,]A2array(int rows, int columns, int min, int max)
{
    int[,] newArray = new int [rows, columns];
    for(int i=0; i<rows; i++)
    for(int j=0; j<columns;j++)
    newArray[i,j]=new Random (). Next (min,max+1);
    return newArray;
}
void C2array(int [,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        Console.Write(array[i,j]+"");
        Console.WriteLine();
    }
}
Console.Write("Imput number of rows:");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns:");
int n= Convert.ToInt32(Console.ReadLine());
string? PosElement = Console.ReadLine();
PosElement = RemovingSpaces(PosElement);
int[] point = ParserString(PosElement);


if(point[0] <= m && point[1] <= n && point[0] >= 0 && point[1] >= 0) 
{
  int result = array(point[0]-1, point[1]-1);
  Console.Write($"Значение элемента: {result}");
}
else Console.Write("Элемент отсутствует");

int[] ParserString(string num)
{
  int countNumbers = 1;
  for (int i = 0; i < num.Length; i++)
  {
      if (num[i] == ',')
      countNumbers++;
  }
int[] number = new int[countNumbers];


  int Numberindex = 0;
  for(int i = 0; i < num.Length; i++)
  {
    string subString = String.Empty;


    while (num[i] != ',')
    {
    subString += num[i].ToString();
    if (i >= num.Length - 1) break;
    i++;
    }
    number[Numberindex] = Convert.ToInt32(subString);
    Numberindex++;
  }
return number;
}


string RemovingSpaces (string num)
{ 
  string anum = String.Empty;
  for (int i = 0; i < num.Length; i++)
  {
    if (num[i] != ' ') 
    {
      anum += num[i];
    }
  }
  return anum;
}

