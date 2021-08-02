using System;


namespace Game
{
    class Player
    {
        public int playerhp = 100;
        public int Atack(IGuns gun)
        {
            return gun.Shoot();
        }
        public IGuns GunChange()
        {
            IGuns lasergun = new LaserGun();
            IGuns pistol = new Pistol();
            string gunchoser = Console.ReadLine();
            if (gunchoser == "lasergun")
            {
                return lasergun;
            }
            else
            {
                return pistol;
            }
        }
    }
}
