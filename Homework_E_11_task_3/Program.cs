using System;

namespace Homework_E_11_task_3
{
    interface IArrayList<T>
    {
        void Add(T item);
        T Get(int index);
        int Len();
        void PrintArrayList();
        void RemoveByIndex(int index);
        void RemoveByName(T item);
        void RemoveAll();
    }
    class ArrayList<T>: IArrayList<T>
    {
        T[]? array = new T[0];
        int dinamicLength = 0;
        
        public void Add(T item)
        {
            dinamicLength++;
            T[] tempArray = new T[dinamicLength];
            if(array.Length > 0 )
            {
                for(int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i]; 
                }
            }
            tempArray[dinamicLength - 1] = item;
            array = tempArray;
        }
        public T Get(int index)
        {
            return array[index];
        }
        public int Len()
        {
            return dinamicLength;
        }
        public void PrintArrayList()
        {
            for (int i = 0; i < dinamicLength; i++)
            {
                Console.WriteLine($"[{array[i]}]");
            }
        }
        public void RemoveByIndex(int index)
        {
            dinamicLength--;
            T[] tempArray = new T[dinamicLength];
            if (array.Length > 0)
            {
                if (index >= 0 && index < array.Length)
                {
                    for (int i = 0; i < index; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    for (int i = index; i < tempArray.Length; i++)
                    {
                        tempArray[i] = array[i+1];
                    }

                    array = tempArray;
                }
                else
                {
                    Console.WriteLine("Sorry youre index out of range");
                }
            }
            else
            {
                Console.WriteLine("Array list is empty");
            }
        }

        public void RemoveByName(T item)
        {
            if (array.Length > 0)
            {
                int numberOfDeleted = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i].Equals(item))
                    {
                        numberOfDeleted++;

                        dinamicLength--;
                        T[] tempArray = new T[dinamicLength];

                        for (int j = 0; j < i; j++)
                        {
                            tempArray[j] = array[j];
                        }

                        for (int j = i; j < tempArray.Length; j++)
                        {
                            tempArray[j] = array[j + 1];
                        }

                        array = tempArray;
                        i--;
                    }
                }
                Console.WriteLine($"{numberOfDeleted} elements was deleted");
            }
        }

        public void RemoveAll()
        {
            array = default;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IArrayList<string> list = new ArrayList<string>();

            list.Add("2");
            list.Add("1");
            list.Add("2");
            list.Add("4");
            list.Add("3");
            list.Add("2");
            list.Add("2");
            list.Add("4");
            list.Add("1");
            list.Add("2");
            list.Add("2");
            list.Add("4");

            list.PrintArrayList();
            Console.WriteLine();
            list.RemoveByIndex(1);
            list.PrintArrayList();

            Console.WriteLine();
            list.RemoveByName("2");
            list.PrintArrayList();

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Len());

            list.RemoveAll();
        }
    }
}