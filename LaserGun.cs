using System;


namespace Game
{
    class LaserGun : IGuns
    {
        private const int damage = 50;
        int chamber = 1;
        public void Reload()
        {
            Console.WriteLine("RELOADING");
            chamber = 1;
        }
        public int Shoot()
        {
            if (chamber > 0)
            {
                chamber--;
                Console.WriteLine("BOOM");
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
