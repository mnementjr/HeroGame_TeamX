using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    public class Shrek : Hero, IArcher
    {
        public double Damage { private set; get; }
        public Shrek() : base("Шрек", RaceType.Orc, ProffesionType.Archer, 2000)
        {
            Damage = 100;
        }
        public void InflictShotDamage(Hero anotherHero)
        {
            anotherHero.DecreaseHealth(Damage * Strength);
        }
    }
}
