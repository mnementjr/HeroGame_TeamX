using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace HeroGame
{

    public class Item
    {
        public string name;
        public double itemCost;
    }

    public class Equipment : Item
    {
        public Rarity equipmentRarity;
        public double equipmentDurability;
    }

    public class Weapon : Equipment
    {
        public double Damage;
        public WeaponType weaponType;
        public Weapon(string name, Rarity rarity, double durablity, double damage, WeaponType weaponType, double cost)
        {
            this.name = name;
            equipmentRarity = rarity;
            equipmentDurability = durablity;
            Damage = damage;
            this.weaponType = weaponType;
            itemCost = cost;
        }
    }

    public class Armor : Equipment
    {
        public double Defence;
        public Armor(string name, Rarity rarity, double durablity, double defence, double cost)
        {
            this.name = name;
            equipmentRarity = rarity;
            equipmentDurability = durablity;
            Defence = defence;
            itemCost = cost;
        }
    }

    public class Inventory
    {
        public Armor helmet;
        public Armor chesplate;
        public Armor leggings;
        public Armor boots;
        public Armor belt;
        public Armor shield;
        public Weapon oneHand;
        public double GetDefence()
        {
            double defence = 0;
            if(helmet != null)
            {
                defence += helmet.Defence;
            }
            if(chesplate != null)
            {
                defence += chesplate.Defence;
            }
            if(leggings != null)
            {
                defence += leggings.Defence;
            }
            if(boots != null)
            {
                defence += boots.Defence;
            }
            if(shield != null)
            {
                defence += shield.Defence;
            }
            return defence;
        }
        public double GetDamage()
        {
            double damage = 0;
            if(oneHand != null)
            {
                damage += oneHand.Damage;
            }
            return damage;
        }
    }
}
