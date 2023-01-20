namespace Homework_E_9_task_2
{

    public delegate double MidValueDelegat();
    public delegate int Delegats();
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegats[] delegatsArr = new Delegats[] {getDelegat(), getDelegat(), getDelegat(), 
                getDelegat(), getDelegat(), getDelegat(), getDelegat()};

            for (int i = 0; i < delegatsArr.Length; i++)
            {
                Console.WriteLine($"Delegat {i+1} is {delegatsArr[i].Invoke()}");
            }

            MidValueDelegat midValueDelegat;
            double sum = 0;

            midValueDelegat = delegate { 
                for(int i = 0; i < delegatsArr.Length; i++) {
                    double num = delegatsArr[i].Invoke();
                    sum += num; };
                return sum / delegatsArr.Length; };
            Console.WriteLine($"Midle value will be {midValueDelegat.Invoke()}");
        }

        static Delegats getDelegat()
        {
            Delegats delegats = new Delegats(RandValue.RandomeValue);
            return delegats;
        }
    }

    static class RandValue
    {
        public static int RandomeValue()
        {
            Random rnd = new Random();
            return rnd.Next(10);
        }
    }
}