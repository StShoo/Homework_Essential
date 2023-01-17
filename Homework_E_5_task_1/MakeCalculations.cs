using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_5_task_1
{
    internal class MakeCalculations
    {
        int size;
        public MakeCalculations(int size) 
        {
            this.size = size;
        }

        private int[] DefineArray()
        {
            Array myArray = new Array(size);
            return myArray.GetArray();
        }

        public void PrintCalculations()
        {
            int [] arr = DefineArray();  
            Console.WriteLine($"Max value is {FindMax(arr)}\n" +
                $"Min value is {FindMin(arr)}\n" +
                $"Sum of all elements is {FindSum(arr)}\n" +
                $"Middle value is {FindMiddleValue(arr)}");

            Console.WriteLine("All Even numbers in array:");
            PrintAllEven(arr);
        }

        private int FindMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 0 ; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        private int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        private double FindSum(int[] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length;i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private double FindMiddleValue(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return Convert.ToDouble(sum)/ Convert.ToDouble(arr.Length);
        }

        private void PrintAllEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) { Console.WriteLine(arr[i]); }
            }
        }
    }
}
