using System.Collections;

namespace Homework_E_14_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myCollection = new MyList<int>(5);

            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);
            myCollection.Add(4);
            myCollection.Add(5);

            foreach(int i in myCollection)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Value of 2 is {myCollection.ValueOf(2)}");
            Console.WriteLine($"Length is {myCollection.Len()}");

            int[] array = myCollection.GetArray();
            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    public static class ExtentionClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
        }
    }

    public class MyList<T>: IEnumerable<T>, IEnumerable, IEnumerator<T>
    {
        readonly int length;
        int addedValuesCounter = 0;
        int position= -1;
        T[]? myList = null;

        public T Current => myList[position];

        object IEnumerator.Current => myList[position];

        public MyList(int length)
        {
            this.length = length;
            myList = new T[length];
        }

        public void Add(T valueToAdd)
        {
            myList[addedValuesCounter] = valueToAdd;
            addedValuesCounter++;
        }

        public T ValueOf(int index)
        {
            try
            {
                return myList[index];
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry could not find value with such index.\nResult is set to defult.");
                return default;
            }
        }

        public int Len()
        {
            return length;
        }

        public bool MoveNext()
        {
            if(position < myList.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose(){}

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)myList).GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return myList.GetEnumerator();
        }
    }
}