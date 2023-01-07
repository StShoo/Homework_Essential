using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_5_task_2
{
    internal class MyMatrix
    {
        int len;
        int wid;

        public MyMatrix(int len, int wid)
        {
            this.len = len;
            this.wid = wid;
        }

        private int[,] CrateMatrix()
        {
            int[,] matrix = new int[len, wid];
            return matrix;
        }

        private int[,] FillMatrix(int[,] matrix)
        {
            Random random= new Random();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
            return matrix;
        }

        public void PrintMatrix()
        {
            int[,] matrix = FillMatrix(CrateMatrix());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
