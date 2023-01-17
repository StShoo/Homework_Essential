namespace Homework_E_7_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] trainArray = new Train[3];

            trainArray = SortTrainArray(FillTrainArray(trainArray));

            Console.WriteLine("Information about all youre trains: \n");
            PrintResult(trainArray);

            Console.WriteLine("To see information about youre train, enter it`s number: ");
            int numberOfTrainToFind = ReadIntValue();

            FindTrainByNumber(numberOfTrainToFind, trainArray);
        }

        private static void FindTrainByNumber(int numberOfTrainToFind, Train[] trainArray)
        {
            bool result = false;

            for(int i = 0; i < trainArray.Length; i++) 
            {
                if (trainArray[i].TrainNumber == numberOfTrainToFind)
                {
                    result = true;

                    Console.WriteLine($"Destenation name for {trainArray[i].TrainNumber} train is: {trainArray[i].DestinationName}\n");
                    Console.WriteLine($"Time of arraival for {trainArray[i].TrainNumber} train is: {trainArray[i].TimeOfArraival}\n");

                    break;
                }
            }

            if(!result)
            {
                Console.WriteLine("Sorry could not find youre train");
            }
        }

        private static Train[] SortTrainArray(Train[] trainArray)
        {
            Train temp;

            for (int i = 0; i < trainArray.Length; i++)
            {
                for (int j = 0; j < trainArray.Length - 1; j++)
                {
                    if (trainArray[j].TrainNumber > trainArray[j + 1].TrainNumber)
                    {
                        temp = trainArray[j + 1];
                        trainArray[j + 1] = trainArray[j];
                        trainArray[j] = temp;
                    }
                }
            }

            return trainArray;
        }

        private static Train[] FillTrainArray(Train[] trainArray)
        {
            for (int i = 0; i < trainArray.Length; i++)
            {
                Console.Write($"Enter destenation name for {i + 1} train: ");
                trainArray[i].DestinationName = Console.ReadLine();

                Console.Write($"Enter train number for {i + 1} train: ");
                trainArray[i].TrainNumber = ReadIntValue();

                Console.Write($"Enter time of arraival for {i + 1} train: ");
                trainArray[i].TimeOfArraival = Console.ReadLine();
            }

            return trainArray;
        }

        private static void PrintResult(Train[] trainArray)
        {
            for (int i = 0; i < trainArray.Length; i++)
            {
                Console.WriteLine($"Destenation name for {i + 1} train is: {trainArray[i].DestinationName}\n");

                Console.WriteLine($"Train number for {i + 1} train is: {trainArray[i].TrainNumber}\n");

                Console.WriteLine($"Time of arraival for {i + 1} train is: {trainArray[i].TimeOfArraival}\n");
            }
        }

        private static int ReadIntValue()
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

    struct Train
    {
        string destinationName;
        int trainNumber;
        string timeOfArraival;

        public string DestinationName
        {
            get { return destinationName; }
            set { destinationName = value; }
        }

        public int TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }

        public string TimeOfArraival
        {
            get { return timeOfArraival; }
            set { timeOfArraival = value;}
        }
    }
}