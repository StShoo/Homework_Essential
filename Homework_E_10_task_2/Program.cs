namespace Homework_E_10_task_2
{
    public interface ICreature<out T>
    {
        T Name { get;}
        void OpenBag() { }
    }

    class Creature { }
    class Human: Creature { }
    class Monster: Creature { }

    public class MagicBag<T> : ICreature<T>
    {
        public T Name { get;}
        private bool humanFlag = false;
        private bool monsterFlag = false;

        public MagicBag(T Name) 
        {
            this.Name = Name;
        }
        public void OpenBag()
        {
            if(typeof(T) == typeof(Monster))
            {
                if (!monsterFlag)
                {
                    monsterFlag = true;
                    Console.WriteLine("You are monster. You get coal.");
                }
                else
                {
                    Console.WriteLine("You are monster. You already got youre present.");
                }
            } else if(typeof(T) == typeof(Human))
            {
                if (!humanFlag)
                {
                    humanFlag = true;
                    Console.WriteLine("You are humen. You get chocolate.");
                }
                else
                {
                    Console.WriteLine("You are humen. You already got youre present.");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Monster monster= new Monster();

            ICreature<Creature> magicBag1 = new MagicBag<Human>(human);
            ICreature<Creature> magicBag2 = new MagicBag<Monster>(monster);

            magicBag1.OpenBag();
            magicBag2.OpenBag();
            magicBag1.OpenBag();
            magicBag2.OpenBag();
        }
    }
}