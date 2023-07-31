// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int arrayLength= 5;
int [] array= new int [arrayLength];

int max=array[0];
int min=array[0];

for (int i = 0; i < arrayLength; i++)
{
     array[i]= new Random().Next(100);
    System.Console.Write(array[i]);
    if(i>max)
{
    i=max;
}

if(i<min)
{
    i=min;
}

}

System.Console.WriteLine();
System.Console.WriteLine(max-min);

