using System;


namespace Game
{
    class Mobs
    {
        Random random = new Random();
        public int CreateMob()
        {
            int mobHp = random.Next(50, 100);
            return mobHp;
        }
        public int MobAtack()
        {
            int mobDamage = random.Next(10, 40);
            Console.WriteLine("Mob atack with damage=" + mobDamage);
            return mobDamage;
        }
    }
}
