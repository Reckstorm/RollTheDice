namespace Classwork_08._10._2022.Dice
{
    internal class Player
    {
        public string Name { get; set; }
        public int Count { get; private set; }

        private Game PlayerGame;
        private Player()  {  }
        public Player(string name)
        {
            Name = name;
            Count = 0;
            PlayerGame = new Game();
        }

        public void PlayTheGame()
        {
           Count += PlayerGame.RollTheDice().Draw();
        }
    }
}
