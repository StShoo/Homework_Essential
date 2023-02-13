using System.Collections;

namespace Homework_E_18_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary.MyDictionary myDict = new Dictionary.MyDictionary(4);
            myDict.Add(4, "Even");
            myDict.Add(3, "Odd");
            myDict.Add(7, "Odd");
            myDict.Add(5, "Odd");
            Console.WriteLine($"Item of 2 element is {myDict.ValueOf(2)}");
            Console.WriteLine($"Length is {myDict.Len()}");
        }
    }
}

namespace Dictionary
{
    class MyDictionary : IEnumerable, IEnumerator
    {
        readonly int length;
        int addedValuesCounter = 0;
        int position = -1;
        public DictElement[]? myDictionary = null;

        public object Current => myDictionary[position];

        public MyDictionary(int length)
        {
            this.length = length;
            myDictionary = new DictElement[length];
        }

        public void Add(int key, string item)
        {
            myDictionary[addedValuesCounter] = new DictElement(key, item);
            addedValuesCounter++;
        }

        public string ValueOf(int index)
        {
            try
            {
                return myDictionary[index].Item;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry could not find item with such index.\nResult is set to defult.");
                return default;
            }
        }

        public int Len()
        {
            return length;
        }

        public bool MoveNext()
        {
            if (position < myDictionary.Length - 1)
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

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }

    class DictElement
    {
        private int key;
        private string item;

        public DictElement(int key, string item)
        {
            this.key = key;
            this.item = item;
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public string Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}