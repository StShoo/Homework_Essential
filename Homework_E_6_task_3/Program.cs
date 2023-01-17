namespace Homework_E_6_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[10] {17, 22, 5, -2, 1, 0, 23, 5, 0, 100};

            ExtentionClass.ExtentionMethod(myArr);
        }
    }

    static class ExtentionClass
    {
        public static void ExtentionMethod(this int[] arrayToSort)
        {
            int temp = 0;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j < arrayToSort.Length - 1; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        temp = arrayToSort[j + 1];
                        arrayToSort[j + 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }
        }
    }
}