using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
    class Item
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        ItemClass tier;
        public ItemClass Tier
        {
            get
            {
                return tier;
            }
            set
            {
                tier = value;
            }
        }

        ItemType type;
        public ItemType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        int armorClass = 0;
        public int ArmorClass
        {
            get
            {
                return armorClass;
            }
            set
            {
                armorClass = value;
            }
        }

        int gpCost = 0;
        public int GPCost
        {
            get
            {
                return gpCost;
            }
            set
            {
                gpCost = value;
            }
        }

        int strReq = 0;
        public int STRReq
        {
            get
            {
                return strReq;
            }
            set
            {
                strReq = value;
            }
        }

        bool stealth = false;
        public bool Stealth
        {
            get
            {
                return stealth;
            }
            set
            {
                stealth = value;
            }
        }

        Die die;
        public Die Die
        {
            get
            {
                return die;
            }
            set
            {
                die = value;
            }
        }

        ItemProperties[] properties = new ItemProperties[3];
        public ItemProperties[] Properties
        {
            get
            {
                return properties;
            }
            set
            {
                properties = value;
            }
        }

        Rarity rarity;
        public Rarity Rarity
        {
            get
            {
                return rarity;
            }
            set
            {
                rarity = value;
            }
        }

        AttackType attackType;
        public AttackType AttackType
        {
            get
            {
                return attackType;
            }
            set
            {
                attackType = value;
            }
        }

        string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }


    }
}
