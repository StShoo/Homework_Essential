using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_5_task_1
{
    internal class Array
    {
        int n;
        int[] arr;

        public Array(int n)
        {
            this.n = n;
        }

        private void CreateArray()
        {
            arr = new int[n];
        }

        private void FillArray()
        {
            CreateArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i+1} element of array: ");
                int num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }
        }

        public int[] GetArray()
        {
            FillArray();
            return arr;
        }
    }
}
