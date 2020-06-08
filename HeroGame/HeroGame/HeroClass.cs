using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   
    class HeroClass
    {
        public enum WeaponType { Pike, Palberg, TwoHandedAxe, Sword, Axe, blunt }
        public enum RaceType { Elf, Orc, Human, Dwarf }
        public enum Rarity { Common, Rare, Epic, Legendary }
        public enum ProffesionType { Warrior, Archer, Mage }
        public class Hero
        {
            public const double MAX_STAMINA = 100;
            public readonly double MAX_HEALTH = 100;
            public readonly double MAX_MANA = 100;
            public string Name { set; get; }
            public double CurrentHealth { set; get; }       
            public double CurrentStamina { set; get; } 
            public double CurrentMana { set; get; }
            public bool IsAlive { set; get; }
            public WeaponType Weapon { set; get; }
            public RaceType Race { set; get; }
            public ProffesionType Proffesion { set; get; }
            // public Character character { set; get; }
            // public Proffesion proffesion { set; get; }

                   
            public void DecreaseHealth(double amountHealth)
            {
                if (CurrentHealth - amountHealth > 0)   // 1000 - 2000 = -1000
                {
                    CurrentHealth -= amountHealth;
                }
                else
                {
                    IsAlive = false;
                    CurrentHealth = 0;
                }

            }
            public void IncreaseHealth(double amountHealth)
            {
                if (CurrentHealth + amountHealth < MAX_HEALTH)
                {
                    CurrentHealth += amountHealth;
                }
                else
                {
                    CurrentHealth = MAX_HEALTH;
                }
            }
            public void DecreaseStamina (double amountStamina)
            {
                if (CurrentStamina - amountStamina > 0)   // 1000 - 2000 = -1000
                {
                    CurrentStamina -= amountStamina;
                }
                else
                {
                    CurrentStamina = 0;
                }
            }
            public void IncreaseStamina(double amountStamina)
            {
                if (CurrentStamina + amountStamina < MAX_STAMINA)   // 1000 - 2000 = -1000
                {
                    CurrentStamina += amountStamina;
                }
                else
                {
                    CurrentStamina = MAX_STAMINA;
                }
            }
            public void DecreaseMana(double amountMana)
            {
                if (CurrentMana - amountMana > 0)   // 1000 - 2000 = -1000
                {
                    CurrentMana -= amountMana;
                }
                else
                {
                    CurrentMana = 0;
                }
            }
            public void IncreaseMana(double amountMana)
            {
                if (CurrentMana + amountMana < MAX_MANA)   // 1000 - 2000 = -1000
                {
                    CurrentMana += amountMana;
                }
                else
                {
                    CurrentMana = MAX_MANA;
                }
            }

        }

    }
}
