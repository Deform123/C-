Console.Clear();

Console.Write("Введите размерность массива : ");

Console.WriteLine();

Console.Write("A : ");
int A = int.Parse(Console.ReadLine());
Console.Write("B : ");
int B = int.Parse(Console.ReadLine());
Console.Write("C : ");
int C = int.Parse(Console.ReadLine());

int [,,] array = FillArray(A, B, C, 10,100);

PrintArray(array);

int [,,] FillArray(int rows, int columns, int layer, int min, int max)
{
    int [,,] array = new int [rows, columns, layer];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < layer; k++)
            {
                array[i,j,k] = new Random().Next(min,max);
            }
    return array;
}

void PrintArray(int [,,] filledArray)
{
    for(int i = 0; i < filledArray.GetLength(0); i++)
    {
        for(int j = 0; j < filledArray.GetLength(1); j++)
        {
             for (int k = 0; k < filledArray.GetLength(2); k++)
            {
                Console.Write( $"{filledArray[i,j,k]}({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
    }
}
