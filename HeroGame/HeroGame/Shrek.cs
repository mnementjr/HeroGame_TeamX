using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    public class Shrek : Hero
    {
        public Shrek() : base("Шрек", RaceType.Orc, ProffesionType.Warrior, 2000)
        {
            
        }
        public string Print()
        {
            return "\nName " + this.Name + "\nRace " + this.Race + "\nProffesion " + this.Proffesion + "\nCurrent Health " + this.CurrentHealth +
                "\nCurrent Stamina " + this.CurrentStamina + "\nCurrent Mana " + this.CurrentMana + "\nStrength " + this.Strength +
                "\nAgility " + this.Agility + "\nDamage " + this.BasedDamage + "\n";
        }
    }
}
