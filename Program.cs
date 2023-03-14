// 8.	В заданной матрице А(n*n) найти минимум всех сумм абсолютных величин элементов матрицы по
// столбцам. Для нахождения суммы абсолютных величин столбца использовать функцию.

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] inputMatrix = MatrixUtil.inputMatrix();
            
            MatrixUtil.printMatrix(inputMatrix);
            
            int result = MatrixUtil.getMinColumnSum(inputMatrix);
            
            Console.Write($"Result is: {result.ToString()}");
        }
    }

    internal class MatrixUtil
    {
        public static int[,] inputMatrix()
        {
            Console.Write("Введите размер массива: ");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int[,] matrix = new int[size, size];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var enterRow = Console.ReadLine();
                string[] matrixRow = enterRow.Split(new char[] { ' ' });
                
                for (int j = 0; j < matrixRow.Length; j++)
                {
                    matrix[i, j] = int.Parse(matrixRow[j]);
                }
            }

            return matrix;
        }

        public static void printMatrix(int[,] inputMatrix)
        {
            int rows = inputMatrix.GetLength(0);
            int columns = rows;

            Console.WriteLine();
            Console.WriteLine("Matrix:");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{inputMatrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int getMinColumnSum(int[,] inputMatrix)
        {
            int sum = -1;
            
            for (int col = 0; col < inputMatrix.GetLength(0); col++)
            {
                int currentSum = 0;
                
                for (int row = 0; row < inputMatrix.GetLength(1); row++)
                {
                    currentSum += Math.Abs(inputMatrix[row, col]);
                }
                if (currentSum < sum || sum == -1)
                {
                    sum = currentSum;
                }
            }

            return sum;
        }
    }
}

