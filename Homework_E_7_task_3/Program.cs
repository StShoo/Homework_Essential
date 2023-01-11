namespace Homework_E_7_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("MSI GF63", 44000, "MSI");

            Printresult(notebook);
        }

        static void Printresult(Notebook notebook)
        {
            Console.WriteLine($"Youre notebook model: {notebook.Model}\n" +
                $"Youre notebook manufacturer: {notebook.Manufactorer}\n" +
                $"Yre notebook price: {notebook.Price}");
        }
    }

    struct Notebook
    {
        string model, manufacturer;
        double price;

        public Notebook(string model, double price, string manufacturer)
        {
            this.model = model;
            this.price = price;
            this.manufacturer = manufacturer;
        }

        public string Model
        {
            get { return model; }
        }

        public string Manufactorer
        {
            get { return manufacturer; }
        }

        public double Price
        {
            get { return price; }
        }
    }
}