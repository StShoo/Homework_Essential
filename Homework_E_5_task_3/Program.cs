namespace Homework_E_5_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Article[] article = store.CreateArrayOfArticles();
            
            for(int i = 0; i < article.Length; i++)
            {
                Console.WriteLine($"{i} product info\n" + $"Name: {article[i].Name}\n"
                    + $"Shop name: {article[i].ShopName}\n" + $"Cost: {article[i].Cost}\n" + $"");
            }

            Console.Write("Enter product name you want to find: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            bool productWasFound = false;

            for (int i = 0; i < article.Length; i++)
            {
                if (name.Equals(article[i].Name))
                {
                    Console.WriteLine($"Your product info\n" + $"Name: {article[i].Name}\n"
                    + $"Shop name: {article[i].ShopName}\n" + $"Cost: {article[i].Cost}\n" + $"");
                    productWasFound = true;
                    break;
                }
            }

            if (!productWasFound)
            {
                Console.WriteLine("Нажаль ми не знайшли ваш продукт");
            }

            Console.Write("Enter product index: ");
            int index = ReadValue();

            if (index >= 0 && index < article.Length) 
            {
                Console.WriteLine($"Your product info\n" + $"Name: {article[index].Name}\n"
                    + $"Shop name: {article[index].ShopName}\n" + $"Cost: {article[index].Cost}\n" + $"");
            }
            else
            {
                Console.WriteLine("Нажаль ми не знайшли ваш продукт");
            }
        }

        static int ReadValue()
        {
            do
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Please enter only int values");
                }
            } while (true);
        }
    }
}