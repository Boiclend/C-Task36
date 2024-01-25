using System.Numerics;

Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
if(!(N >= 1) && !(N <= 100))
{
    throw new Exception("Not a correct value");
}
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
if(!(M >= 1) && !(M <= 100))
{
    throw new Exception("Not a correct value");
}

char[,] getMatrix(int n, int m)
{
    char[,] matrix = new char[n,m];
    Console.WriteLine("Заполните матрицу символами - или *, где - это свободное место, а * занятое");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = char.Parse(Console.ReadLine());
            if((matrix[i,j] != '*' && matrix[i,j] == '-') || matrix[i,j] == '*' && matrix[i,j] != '-' )
            {

            }
            else
            {
                throw new Exception("Not a coorect format for element in matrix");
            }
            
        }
        Console.WriteLine();
    }
    return matrix;
}

void printMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void InsertCross(char[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            try
            {
                if(matrix[i,j] != '*' && matrix[i - 1,j] != '*' && matrix[i,j - 1] != '*' && matrix[i + 1,j] != '*' && matrix[i,j + 1] != '*')
                {
                count++;
                }
     
            }
            catch
            {
                count++;
            }
            finally
            {
                
            }
        }
    }
    Console.WriteLine($"Крестик можно поместить {count} раз");
}

char[,] myArray = getMatrix(N,M);
printMatrix(myArray);
InsertCross(myArray);