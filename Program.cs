using System;


namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Level startgame = new Level();
            IGuns gun = new Pistol();
            int counter = 0;
            startgame.LevelGo(counter, gun);
            Console.ReadLine();
        }
    }
}
