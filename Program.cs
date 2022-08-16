Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetSum(int[,] tArray, int m, int n)
{
double Sum = 0;
int count = 0;

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        Sum = Sum + tArray[i, j];
        count++;   
        if (i == (m-1))    Console.Write(" " + Sum/count);                
    }
  Sum = 0;
  count = 0;
}
     
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
GetSum(array, rows, columns);
