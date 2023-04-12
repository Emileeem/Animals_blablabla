using System;
using static System.Console;

Game game = new Game ();
game.Start();

while (true)
{
    var command = ReadKey(true);
    var key = command.Key;
    switch (key)
    {
        case ConsoleKey.Q:
            game.YourShop.Buy(0, game.YourTeam);
            break;
        case ConsoleKey.W:
            game.YourShop.Buy(1, game.YourTeam);
            break;
        case ConsoleKey.E:
            game.YourShop.Buy(2, game.YourTeam);
            break;
        case ConsoleKey.R:
            game.YourShop.Refill();
            break;
    }
    Clear();
    WriteLine(game);
}