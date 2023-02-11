namespace Homework_E_17_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stopProgram;
            dynamic word;
            var uaEngDict = new Dictionary<string, string>
            {
                {"пес", "dog"},
                {"троянда", "rose"},
                {"пиво", "beer"},
                {"півень", "cock"},
                {"яблуко", "apple"},
                {"картина", "picture"},
                {"мапа", "map"},
                {"диск", "disk"},
                {"подорож", "trip"},
                {"кава", "coffee"},
            };

            do
            {
                Console.Write("Впищіть слово яке хочете перекласти: ");
                word = Console.ReadLine();

                foreach(var element in uaEngDict)
                {
                    if (element.Key.Equals(word))
                    {
                        Console.WriteLine($"Переклад {word} - {element.Value}");
                        break;
                    }
                    if (element.Value.Equals(word))
                    {
                        Console.WriteLine($"Переклад {word} - {element.Key}");
                        break;
                    }
                }

                Console.WriteLine("Хочете закінчити?\n" +
                    "Y/N");
                if(Console.ReadLine() == "y")
                {
                    stopProgram= false;
                }
                else
                {
                    stopProgram= true;
                }
            } while (stopProgram);
        }
    }
}