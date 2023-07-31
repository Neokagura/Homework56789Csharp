// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int arrayLength= 5;
int[] array= new int [arrayLength];

int count=0;

for (int i = 0; i < arrayLength; i++)
{
    array[i]= new Random().Next(99);
    System.Console.Write(array[i]+ " ");

    if (i%2==1)
    {
        count= count+ array[i];
    }

}
System.Console.WriteLine();
System.Console.WriteLine(count);