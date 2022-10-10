namespace Classwork_08._10._2022.Dice
{
    internal class Game
    {
        public Dice[] Arr { get; private set; }
        private Random random;
        public Game()
        {
            Arr = new Dice[6] { new DiceOne(), new DiceTwo(), new DiceThree(), new DiceFour(), new DiceFive(), new DiceSix() };
            random = new Random();
        }
        public Dice RollTheDice()
        {
            return this.Arr[random.Next(6)];
        }
    }
}
