//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int arrayLength= 5;
int[] array= new int [arrayLength];

int count=0;

for (int i = 0; i < arrayLength; i++)
{
    array[i]= new Random().Next(100,1000);
    System.Console.Write(array[i]+ " ");

    if (array[i]%2==0)
    {
        count= count+1;

    }
}
System.Console.WriteLine();
System.Console.WriteLine(count);
