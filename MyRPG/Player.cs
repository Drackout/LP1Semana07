using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;

        public string Name {get;set;}

        public int XP
        {
            get => xp;
            set 
            {
                if (value > 0)
                    xp += value;
            }
        }

        public int Level => (1+XP/1000);

        public float Health
        {
            get => health;
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > MaxHealth)
                    health = MaxHealth;
            }
        }

        public float MaxHealth => 100+(Level-1)*20;

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health > 0)
                Health = 0;

            xp += (int)damage / 20;
        }

        public Player(string name)
        {
            Name = name;
            XP = 0;
            health = MaxHealth;
        }


    }
}