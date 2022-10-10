namespace Classwork_08._10._2022.Dice
{
    internal class Dice
    {
        public int Value { get; private set; }
        private int Size;
        private Dice() { }
        protected Dice(int value)
        {
            Value = value;
            Size = 9;
        }

        public int Draw()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == 0 || j == 0 || i == Size - 1 || j == Size - 1)
                    {
                        Console.Write('*');
                    }
                    else if (i == Size / 2 && j == Size / 2)
                    {
                        Console.Write(Value);
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
            return Value;
        }
    }
}
