using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    public enum WeaponType { Pike, Palberg, TwoHandedAxe, Sword, Axe, blunt }
    public enum RaceType { Elf, Orc, Human, Dwarf }
    public enum Rarity { Common, Rare, Epic, Legendary }
    public enum ProffesionType { Warrior, Archer, Mage }

    public abstract class Hero
    {
        public double MAX_STAMINA = 100;
        public readonly double MAX_HEALTH;
        public double MAX_MANA = 100;
        public string Name { set; get; }
        public double CurrentHealth { set; get; }       
        public double CurrentStamina { set; get; } 
        public double CurrentMana { set; get; }
        public bool IsAlive { set; get; }
        public WeaponType Weapon { set; get; }
        public RaceType Race { set; get; }
        public ProffesionType Proffesion { set; get; }
        public double Strength { get; set; }
        public double Agility { get; set; }
        public double Intelligence { get; set; }
        public double Endurance { get; set; }
        public Inventory Inventory { get; set; }

        public Hero(string name, RaceType race, ProffesionType proffesion, double maxHealth)
        {
            this.Name = name;
            this.Race = race;
            this.Proffesion = proffesion;
            MAX_HEALTH = maxHealth;
            Strength = 10;
            Agility = 10;
            Intelligence = 10;
            Endurance = 10;
            CurrentHealth = MAX_HEALTH;
            CurrentMana = MAX_MANA;
            CurrentStamina = MAX_STAMINA;
            // Switch race and proffession to characters
            if (race.Equals(RaceType.Elf))
            {
                MAX_HEALTH = 180;
                Intelligence += 10;
                Strength -= 4;
                Agility += 7;
                Endurance -= 5;
                CurrentHealth = 90;
                CurrentMana = 90;
                CurrentStamina = 100;
            }
            else if (race.Equals(RaceType.Human))
            {
                MAX_HEALTH = 200;
                Intelligence += 9;
                Strength += 5;
                Agility -= 1;
                Endurance += 6;
                CurrentHealth = 100;
                CurrentMana = 60;
                CurrentStamina = 120;
            }
            else if (race.Equals(RaceType.Dwarf))
            {
                MAX_HEALTH = 195;
                Intelligence += 4;
                Strength += 7;
                Agility -= 3;
                Endurance += 15;
                CurrentHealth = 100;
                CurrentMana = 70;
                CurrentStamina = 200;
            }
            else if (race.Equals(RaceType.Orc))
            {
                MAX_HEALTH = 250;
                Intelligence -= 5;
                Strength += 11;
                Agility -= 5;
                Endurance += 7;
                CurrentHealth = 150;
                CurrentMana = 60;
                CurrentStamina = 150;
            }
        }
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
