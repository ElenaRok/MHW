
/*Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Imput number of rows:");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns:");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value:");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value:");
int max= Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[m, n];
NRandom(newarray);
Console.WriteLine();
Console.WriteLine();
Showarray(newarray);       
    for(int i=0; i<newarray.GetLength(0); i++)
    {
       for(int j=0; j<newarray.GetLength(1)-1; j++) 
       { 
         for(int c=0; c<newarray.GetLength(1)-1; c++)
         { 
   
          if( newarray[i,c] < newarray[i,c+1])
          {
             int temp=0;           
                    temp= newarray[i,c];
                    newarray[i,c]= newarray[i,c+1];
                     newarray[i,c+1] = temp;
                  }
               } 
           }     
      }
      Console.WriteLine(); 
      Console.WriteLine(); 
      Showarray(newarray);
      void NRandom (int[,]array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
        array[i,j] =new Random ().Next ();
       }
    }
 }
 void Showarray (int[,]array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     Console.Write("");
     for (int j = 0; j < array.GetLength(0); j++)
     {
         Console.Write(array[i,j]+"");
     }
     Console.Write("");
     Console.WriteLine();
   } 
 }
        
 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.

/*Console.WriteLine("введите размер квадратного массива");
	int massVol = Convert.ToInt32(Console.ReadLine());
	int[,] newarray = new int[massVol, massVol];
     NRandom(newarray);
     Showarray(newarray);

int minsum= Int32.MaxValue;
int line=0;
for(int i=0; i<newarray.GetLength(0);i++)
{
    int sum=0;
    for(int j=0; j<newarray.GetLength(1);j++)
    {
        sum=sum+ newarray[i,j];
    }
    if (sum<minsum)
    {
        minsum=sum;
        line++;
    }
}*/

 /*Console.WriteLine($"Строка с минимальной суммой элементов массива:+{line} с суммой элементов равной{minsum}");
 void NRandom (int[,]array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
        array[i,j] =new Random ().Next ();
       }
    }
 }
 void Showarray (int[,]array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     Console.Write("");
     for (int j = 0; j < array.GetLength(0); j++)
     {
         Console.Write(array[i,j]+"");
     }
     Console.Write("");
     Console.WriteLine();
   } 
 }*/
 //Заполните спирально массив 4 на 4.
/*Console.Write("Imput number of rows:");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number of columns:");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value:");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value:");
int max= Convert.ToInt32(Console.ReadLine());
int[,] myarray= new int[m,n];
int curent=1;
int i=0;
int j=0;
while (curent<=m*n)
{
 myarray[i,j]=curent;
 if (i<=j+1&& i+j<m-1)++j;
 else if (i<j&& i+j>= m-1) ++i;
 else if (i>=j+1&& i+j>m-1)--j;
 else
 --j;
 ++curent;
}
Showarray(myarray);
 void Showarray (int[,]array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     Console.Write("");
     for (int j = 0; j < array.GetLength(0); j++)
     {
         Console.Write(array[i,j]+"");
     }
     Console.Write("");
     Console.WriteLine();
   }
 }*/
 // Что-то в задаче не так(
