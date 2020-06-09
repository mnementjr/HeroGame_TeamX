using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    public enum WeaponType { Pike, Palberg, TwoHandedAxe, Sword, Axe, Bow, Blunt, Crossbow, MagicWand }
    public enum RaceType { Elf, Orc, Human, Dwarf }
    public enum Rarity { Common, Rare, Epic, Legendary }
    public enum ProffesionType { Warrior, Archer, Mage }

    public abstract class Hero
    {
        public double MAX_STAMINA = 100;
        public double MAX_MANA = 100;
        public double MAX_HEALTH;
        public string Name { set; get; }
        public double CurrentHealth { set; get; }       
        public double CurrentStamina { set; get; } 
        public double CurrentMana { set; get; }
        public bool IsAlive { set; get; }
        public RaceType Race { set; get; }
        public ProffesionType Proffesion { set; get; }
        public double Strength { get; set; }
        public double Agility { get; set; }
        public double Intelligence { get; set; }
        public double Endurance { get; set; }
        public Inventory Inventory { get; set; }

        public Hero(string name, RaceType race, ProffesionType proffesion, double maxHealth)
        {
            Name = name;
            Race = race;
            Proffesion = proffesion;
            MAX_HEALTH = maxHealth;
            Strength = 10;
            Agility = 10;
            Intelligence = 10;
            Endurance = 10;
            IsAlive = true;

            ChooseRace(race);
            ChooseProffesion(proffesion);

            CurrentHealth = MAX_HEALTH;
            CurrentMana = MAX_MANA;
            CurrentStamina = MAX_STAMINA;
        }
        public void InflictDamage(Hero anotherHero)
        {
            double damage = Inventory.GetDamage();
            damage += Strength + damage;
            damage -= anotherHero.Inventory.GetDefence();
            anotherHero.DecreaseHealth(damage);
        }
        public void DecreaseHealth(double amountHealth)
        {
            if (CurrentHealth - amountHealth > 0)
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
            if (CurrentStamina - amountStamina > 0)
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
            if (CurrentStamina + amountStamina < MAX_STAMINA)
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
            if (CurrentMana - amountMana > 0)
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
            if (CurrentMana + amountMana < MAX_MANA)
            {
                CurrentMana += amountMana;
            }
            else
            {
                CurrentMana = MAX_MANA;
            }
        }
        private void ChooseRace(RaceType race)
        {
            if (race.Equals(RaceType.Elf))
            {
                MAX_HEALTH += 180;
                Intelligence += 10;
                Strength -= 4;
                Agility += 7;
                Endurance -= 5;
                MAX_HEALTH -= MAX_HEALTH * 0.2;
            }
            else if (race.Equals(RaceType.Human))
            {
                MAX_HEALTH += 200;
                Intelligence += 9;
                Strength += 5;
                Agility -= 1;
                Endurance += 6;
            }
            else if (race.Equals(RaceType.Dwarf))
            {
                MAX_HEALTH -= MAX_HEALTH * 0.3;
                MAX_MANA += 20;
                MAX_STAMINA -= 30;
                Intelligence += 4;
                Strength += 7;
                Agility -= 3;
                Endurance += 15;

            }
            else if (race.Equals(RaceType.Orc))
            {
                MAX_HEALTH += MAX_HEALTH * 0.4;
                MAX_MANA -= MAX_MANA * 0.5;
                MAX_STAMINA += MAX_STAMINA * 0.5;
                Intelligence -= 7;
                Strength += 11;
                Agility -= 5;
                Endurance += 7;
            }
        }
        private void ChooseProffesion(ProffesionType type)
        {
            Inventory = new Inventory();
            if (type.Equals(ProffesionType.Archer))
            {
                Inventory.helmet = new Armor("Archer's helmet", Rarity.Common, 100, 10, 0);
                Inventory.chesplate = new Armor("Archer's chestplate", Rarity.Common, 100, 10, 0);
                Inventory.leggings = new Armor("Archer's leggings", Rarity.Common, 100, 10, 0);
                Inventory.boots = new Armor("Archer's boots", Rarity.Common, 100, 10, 0);
                Inventory.oneHand = new Weapon("Archer's bow", Rarity.Common, 100, 50, WeaponType.Bow, 0);
            }
            else if (type.Equals(ProffesionType.Mage))
            {
                Inventory.helmet = new Armor("Mage's helmet", Rarity.Common, 100, 15, 0);
                Inventory.chesplate = new Armor("Mage's chestplate", Rarity.Common, 100, 15, 0);
                Inventory.leggings = new Armor("Mage's leggings", Rarity.Common, 100, 15, 0);
                Inventory.boots = new Armor("Mage's boots", Rarity.Common, 100, 15, 0);
                Inventory.oneHand = new Weapon("Mage's magic wand", Rarity.Common, 100, 70, WeaponType.MagicWand, 0);
            }
            else if (type.Equals(ProffesionType.Warrior))
            {
                Inventory.helmet = new Armor("Warrior's helmet", Rarity.Common, 150, 20, 0);
                Inventory.chesplate = new Armor("Warrior's chestplate", Rarity.Common, 150, 20, 0);
                Inventory.leggings = new Armor("Warrior's leggings", Rarity.Common, 150, 20, 0);
                Inventory.boots = new Armor("Warrior's boots", Rarity.Common, 150, 20, 0);
                Inventory.oneHand = new Weapon("Warrior's sword", Rarity.Common, 150, 200, WeaponType.Sword, 0);
            }
        }
    }


}
