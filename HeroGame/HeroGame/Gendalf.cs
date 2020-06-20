using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    public class Gendalf : Hero
    {
        public Gendalf() : base("Гендальф", RaceType.Human, ProffesionType.Mage, 2000)
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
