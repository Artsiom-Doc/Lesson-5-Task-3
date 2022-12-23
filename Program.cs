/*Задайте массив вещественных чисел.
 Найдите разницу между максимальным и 
 минимальным элементом массива.
[3.3 7.76 22 2 78.67] -> 76.67*/

double[]FillArray (int length)
{
    double[]arr = new double [length];
    Random rnd = new Random();
    Console.Write("[");
    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(1, 100);
        Console.Write(arr[i]+" ");
    }
    return arr;
}

double [] myArray = FillArray(5);
double max = myArray[0];
double min = myArray[0];
double result = 0;

for(int i = 0; i < 5; i++)
{
    if(myArray[i] > max)
    {
        max = myArray[i];
    }
}
for(int i = 0; i < 5; i++)
{
    if(myArray[i] < min)
    {
        min = myArray[i];
    }
}
result = max - min;    
Console.Write("]-> " + result);