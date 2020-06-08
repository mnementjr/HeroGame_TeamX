using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    interface IWizard
    {
        void InflictMagicDamage(Hero anotherHero);
        void UseSpell();
    }
}
