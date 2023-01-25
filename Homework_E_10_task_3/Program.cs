using System.Collections;
using System.Collections.Generic;

namespace Homework_E_10_task_3
{
    interface IListArray<T>
    {
        public void Add(T valueToAdd);
        public T ValueOf(int index);
        public int Len();
    }

    /*public class Extensions
    {
        public static T[] GetArray<T>(this List<T> list)
        {
            return list.mylist;
        }
    }*/

    public class List<T> : IListArray<T>
    {
        T[]? mylist;
        readonly int listLength;
        int counterAddedValues = 0;

        public List(int listLength)
        {
            this.listLength = listLength;
            mylist = new T[listLength];
        }

        public void Add(T valueToAdd)
        {
            mylist[counterAddedValues] = valueToAdd;
            counterAddedValues++;
        }

        public T ValueOf(int index)
        {
            try
            {
                return mylist[index];
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry could not find value with such index.\nResult is set to defult.");
                return default;
            }
        }

        public int Len()
        {
            return mylist.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter list length: ");
            int len = Convert.ToInt32(Console.ReadLine());
            IListArray<int> list = new List<int>(len);

            list.Add(12);
            list.Add(-17);
            list.Add(2);

            Console.WriteLine(list.Len());
            Console.WriteLine(list.ValueOf(0));
        }
    }
}