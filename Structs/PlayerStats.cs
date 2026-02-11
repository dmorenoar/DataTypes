using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes.Structs
{
    public struct PlayerStats
    {
        //Inmutable properties, can only be set in the constructor
        public int Health { get; } 
        public int Mana { get; }

        public PlayerStats(int health, int mana)
        {
            Health = health;
            Mana = mana;
        }
    }
}
