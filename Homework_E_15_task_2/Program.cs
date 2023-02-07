namespace Homework_E_15_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Price[] goods = new Price[n];

            for (int i = 0; i < goods.Length; i++)
            {
                Console.Write($"Please enter name of {i + 1} good: ");
                goods[i].GoodName = Console.ReadLine();
                Console.Write($"Please enter name of {i + 1} shop: ");
                goods[i].ShopName = Console.ReadLine();
                Console.Write($"Please enter price of {i + 1} good: ");
                goods[i].GoodPrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            for (int i = 0; i < goods.Length; i++)
            {
                Console.WriteLine($"Name of {i + 1} good: {goods[i].GoodName}");
                Console.WriteLine($"Name of {i + 1} shop: {goods[i].ShopName}");
                Console.WriteLine($"Price of {i + 1} good: {goods[i].GoodPrice}");
                Console.WriteLine();
            }

            string ShopNameToFind = Console.ReadLine();

            try
            {
                for (int i = 0; ; i++)
                {
                    if(goods[i].ShopName == ShopNameToFind)
                    {
                        Console.WriteLine($"Name of {i + 1} good: {goods[i].GoodName}");
                        Console.WriteLine($"Name of {i + 1} shop: {goods[i].ShopName}");
                        Console.WriteLine($"Price of {i + 1} good: {goods[i].GoodPrice}");
                        Console.WriteLine();
                        break;
                    }
                }
            } catch(IndexOutOfRangeException e)
            {
                Console.WriteLine($"Sorry, could not find shop {ShopNameToFind}");
            }
        }
    }

    struct Price
    {
        public string GoodName { get; set; }
        public string ShopName { get; set; }
        public int GoodPrice { get; set; }
    }
}