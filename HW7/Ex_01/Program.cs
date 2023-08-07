System.Console.WriteLine("Add a number");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Add a number");
int num2 = Convert.ToInt32(Console.ReadLine());

double [,] matrix= new double [num1, num2];



for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]=Convert.ToDouble(new Random().Next(0,10));
        System.Console.Write(matrix[i,j]+ " ");
    }
    System.Console.WriteLine();
   
}
