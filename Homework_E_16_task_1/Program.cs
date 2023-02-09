namespace Homework_E_16_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1, 23, 1, 23);
            Block block2 = new Block(1, 23, 1, 23);
            
            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());
        }
    }

    class Block
    {
        int side1;
        int side2;
        int side3;
        int side4;

        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Block b = (Block)obj;
            return (side1 == b.side1) && (side2 == b.side2) && (side3 == b.side3) && (side4 == b.side4);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            return $"Block {this.GetType().ToString()}:\n" +
                $"Side 1 - {side1}\n" +
                $"Side 2 - {side2}\n" +
                $"Side 3 - {side3}\n" +
                $"Side 4 - {side4}\n";
        }
    }
}