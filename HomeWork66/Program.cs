/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Marray= new int[M];

void Mnumber (int M)
{
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    Marray[i] = Convert.ToInt32(Console.ReadLine());
}
}
int Garray ( int[]Marray)
{
    int count=0;
    for(int i=0; i<Marray.Length; i++)
    {
        if(Marray[i]>0) count++;
    }
    return count;
}
Mnumber(M);
Console.WriteLine($"Положительных чисел: {Garray (Marray)}"); */
/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.*/
double[,] f= new double[2,2];
double[] CrossPoint= new double[2];
void Arg()
{
    for(int i=0; i<f.GetLength(0); i++)
    {
        Console.Write($"Введите данные {i+1}(y=k*x+b");
      for(int j=0; j<f.GetLength(1); j++) 
      {
        if(j==0)
        Console.Write("Введите число k: ");
       else Console.Write("Введите число b: ");
       f[i,j]= Convert.ToInt32(Console.ReadLine());
      } 
    }
}
double[] Route(double[,]f)
{
    CrossPoint[0]=(f[1,1]- f[0,1])/(f[0,0]-f[1,0]);
    CrossPoint[1]=CrossPoint[0]*f[0,0]+f[0,1];
    return CrossPoint;
}
void Itog(double[,]f)
{
    if(f[0,0]== f[1,0]&& f[0,1]==f[1,1])
    {
     Console.Write("Прямые в одних плоскостях");  
    }
    else if(f[0,0]== f[1,0]&& f[0,1]!=f[1,1])
    {
     Console.Write("Прямые паралельны");   
    }
    else{
        Route(f);
        Console.Write($"Точка пересеченияХ({CrossPoint[0]},{CrossPoint[1]})");
    }
}
Arg();
Itog(f);
/* Вторую решала с коллективным разумом, не уверенна, что правильно сделала*/
