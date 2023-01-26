using System.Collections;

namespace Homework_E_11_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add("String");
            for(int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            // Ресурсозатратно, а також всі елементи myList мають тип object
        }
    }
}