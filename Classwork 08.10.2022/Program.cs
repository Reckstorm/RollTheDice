using Classwork_08._10._2022.Dice;



while (true)
{
    string str;
    Random rand = new Random();
    int control = 0;
    Console.Clear();
    Console.WriteLine("1 - Start game");
    Console.WriteLine("2 - Exit");
    str = Console.ReadLine();
    control = int.Parse(str);
    if (control == 1)
    {
        Console.Clear();
        do
        {
            Console.Clear();
            Console.WriteLine("Enter first Player name:");
            str = Console.ReadLine();
        } while (str == "");

        Player Player1 = new Player(str.Trim());

        do
        {
            Console.Clear();
            Console.WriteLine("Enter second Player name:");
            str = Console.ReadLine();
        } while (str == "");

        Player Player2 = new Player(str.Trim());
        str = "";

        int flag = rand.Next(1);


        for (int i = 0; i < 4; i++)
        {
            if (flag == 1)
            {
                Console.Clear();
                Console.WriteLine($"{Player1.Name}'s move");
                Player1.PlayTheGame();
                Console.WriteLine($"{Player1.Name}'s count is {Player1.Count}");
                Console.ReadKey();
                flag = 0;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Player2.Name}'s move");
                Player2.PlayTheGame();
                Console.WriteLine($"{Player2.Name}'s count is {Player2.Count}");
                Console.ReadKey();
                flag = 1;
            }
        }

        if (Player1.Count > Player2.Count)
        {
            Console.WriteLine($"{Player1.Name} wins!");
            Console.WriteLine($"{Player1.Count} > {Player2.Count}");
            Console.ReadKey();
        }
        else if (Player2.Count > Player1.Count)
        {
            Console.WriteLine($"{Player2.Name} wins!");
            Console.WriteLine($"{Player2.Count} > {Player1.Count}");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Draw");
            Console.WriteLine($"{Player2.Count} = {Player1.Count}");
            Console.ReadKey();
        }
    }
    else if (control == 2)
    {
        Console.Clear();
        Console.WriteLine("Bye-bye");
        Console.ReadKey();
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid command");
        Console.ReadKey();
    }
}