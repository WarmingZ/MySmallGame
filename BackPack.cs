using System;
using System.Collections.Generic;


namespace Game
{
    class BackPack : IBackPack
    {
        public List<string> itemsinbackpack = new List<string>();
        int Heal(int playerhp)
        {
            playerhp += 20;
            if (playerhp > 100)
            {
                playerhp = 100;
            }
            Console.WriteLine("Player healed!New hp is =" + playerhp);
            return playerhp;
        }
        public int UseItem(int playerhp, string whatToUseItem)
        {
            foreach (var item in itemsinbackpack)
            {
                if (item == whatToUseItem)
                {
                    itemsinbackpack.Remove(item);
                    return Heal(playerhp);
                }
                else
                {
                    Console.WriteLine("No such item in backpack");
                }
            }
            return playerhp;
        }

    }

}
