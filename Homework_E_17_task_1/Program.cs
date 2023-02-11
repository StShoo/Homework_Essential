using System.Drawing;
using System.Xml.Schema;

namespace Homework_E_17_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autosData = new List<AutoData>
            {
                new AutoData
                {
                    Brand = "Toyota",
                    Model = "F1777",
                    Year = 2005,
                    Color = "black"
                },
                new AutoData
                {
                    Brand = "Mustang",
                    Model = "C454B",
                    Year = 2020,
                    Color = "yellow"
                },
                new AutoData
                {
                    Brand = "Shkoda",
                    Model = "D1645",
                    Year = 2017,
                    Color = "red"
                }
            };

            var buyersData = new List<BuyerData>
            {
                new BuyerData
                {
                    NameSurname = "Vasil Artemovski",
                    Model = "C454B",
                    PhoneNumber = "09798873652"
                },
                new BuyerData
                {
                    NameSurname = "Mikita Vennichenko",
                    Model = "D1645",
                    PhoneNumber = "09794271602"
                },
                new BuyerData
                {
                    NameSurname = "Sosura Podorojko",
                    Model = "C454B",
                    PhoneNumber = "09698853611"
                }
            };

            var query = from buyer in buyersData
                        from auto in autosData
                        where buyer.NameSurname == "Mikita Vennichenko"
                        where auto.Model == buyer.Model
                        select new
                        {
                            NameSurname = buyer.NameSurname,
                            PhoneNumber = buyer.PhoneNumber,
                            Model = auto.Model,
                            Brand = auto.Brand,
                            Year = auto.Year,
                            Color = auto.Color
                        };

            foreach(var item in query)
            {
                Console.WriteLine($"Buyer info: \n" + $"Name: {item.NameSurname}\n" + $"Phonenumber: {item.PhoneNumber}\n" + $"\n" + $"Car info:\n" + $"Model: {item.Model}\n" + $"Brand: {item.Brand}\n" + $"Year: {item.Year}\n" + $"Color: {item.Color}\n\n");
            }
        }
    }

    class AutoData
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    class BuyerData
    {
        public string NameSurname { get; set; }
        public string Model { get; set; }
        public string PhoneNumber { get; set; }
    }
}