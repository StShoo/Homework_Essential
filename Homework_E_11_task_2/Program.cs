namespace Homework_E_11_task_2
{
    interface IReadOnlyCollection<T>
    {
        T GetNameElement(int index);
        T GetYearElement(int index);
    }

    interface IWriteOnlyCollection<T>
    {
        void SetElements(T name, T year);
        /*void DeleteAll();*/
    }

    class CarCollection<T> : IReadOnlyCollection<T>, IWriteOnlyCollection<T>
    {
        T[,]? carCollection;
        readonly int len;

        public CarCollection(int len)
        {
            this.len = len;
            carCollection = new T[len, 2];
        }

        public void SetElements(T name, T year)
        {
            for (int i = 0; i < len; i++)
            {
                carCollection[i, 0] = name;
                carCollection[i, 1] = year;
            }
        }
        public int GetLength()
        {
            return carCollection.Length / 2;
        }

        public T? GetNameElement(int index)
        {
            try
            {
                return carCollection[index, 0];
            }
            catch (Exception e)
            {
                Console.WriteLine("No element with such index");
                return default;
            }
        }
        public T? GetYearElement(int index)
        {
            try
            {
                return carCollection[index, 1];
            }
            catch (Exception e)
            {
                Console.WriteLine("No element with such index");
                return default;
            }
        }

       /* public void DeleteAll()
        {
            carCollection = default;
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> carPark = new CarCollection<string>(4);
            carPark.SetElements("Ferarri", "2003");
            carPark.SetElements("Zaporojets", "1998");
            carPark.SetElements("Mustang", "2005");
            carPark.SetElements("Tesla", "2021");

            carPark.GetNameElement(1);
            carPark.GetYearElement(1);

            Console.WriteLine(carPark.GetLength());

            /*carPark.DeleteAll();*/
        }
    }
}