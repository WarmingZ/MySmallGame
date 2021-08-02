using System;


namespace Game
{
    class Level
    {
        Mobs mob = new Mobs();
        Player player = new Player();
        BackPack backpack = new BackPack();
        public void LevelGo(int counter, IGuns gun)
        {
            if (counter < 3)
            {
                counter++;
                int mobsHp = mob.CreateMob();
                mobKiller(mobsHp, counter, gun);
            }
            else
            {
                Console.WriteLine("You win");
            }
        }
        public void mobKiller(int mobsHp, int counter, IGuns gun)
        {
            try
            {
                Console.WriteLine("Mobs hp is=" + mobsHp);
                Console.WriteLine("Player hp is=" + player.playerhp);
                player.playerhp -= mob.MobAtack();
                if (player.playerhp <= 0)
                {
                    Console.WriteLine("Game over");
                    return;
                }
                Console.WriteLine("Player hp is=" + player.playerhp);
                Console.WriteLine("Your turn[atack]or[heal]or[changegun]");
                string chose = Console.ReadLine();
                if (chose == "atack")
                {
                    mobsHp -= player.Atack(gun);
                    if (mobsHp <= 0)
                    {
                        Console.WriteLine("Mob is dead");
                        backpack.itemsinbackpack.Add("heal");
                        Console.WriteLine("NEW MOB IS COMING");
                        LevelGo(counter, gun);
                    }
                    else
                    {
                        mobKiller(mobsHp, counter, gun);
                        Console.WriteLine("Mobshp is=" + mobsHp);
                    }
                }
                else if (chose == "heal")
                {
                    string heal = "heal";
                    player.playerhp = backpack.UseItem(player.playerhp, heal);
                    mobKiller(mobsHp, counter, gun);
                }
                else if (chose == "changegun")
                {
                    Console.WriteLine("you can chose betwen [lasergun]or[pistol] they have this amout of ammo in backpack");
                    gun = player.GunChange();
                    mobKiller(mobsHp, counter, gun);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("incorect data" + ex);
            }
        }
    }
}
