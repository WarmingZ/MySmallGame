using System;


namespace Game
{
    class Pistol : IGuns
    {
        private const int damage = 25;
        int chamber = 2;
        public void Reload()
        {
            Console.WriteLine("RELOADING");
            chamber = 2;
        }
        public int Shoot()
        {
            if (chamber > 0)
            {
                chamber--;
                Console.WriteLine("Pew");
                Console.WriteLine("damage=" + damage);
                return damage;
            }
            else
            {
                Reload();
                return 0;
            }
        }
    }
}
