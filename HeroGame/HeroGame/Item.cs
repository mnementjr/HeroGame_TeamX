using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
    public enum Rarity { common, rare, epic, legendary }
    public enum WeaponType { pike, halberg, sword, axe, blunt }

    public class Item
    {
        public string name;
        public double itemCost;
        public double itemWeight;
    }

    public class Equipment : Item
    {
        public Rarity equipmentRarity;
        public int equipmentDurability;
    }

    public class Weapon : Equipment
    {
        public double physicalDamage;
        public double magicalDamage;
        public WeaponType weaponType;
    }

    public class Armor : Equipment
    {
        public double physicalDefence;
        public double magicalDefence;
    }

    public class Inventory
    {
        public Armor helmet;
        public Armor body;
        public Armor belt;
        public Armor boots;
        public Armor shield;
        public Weapon oneHand;
    }
}
