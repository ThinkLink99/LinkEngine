﻿using System.Collections.Generic;

namespace LinkEngine
{
    public class Enemy : Entity
    {
        public short Strength { get; set; }
        public short Defense { get; set; }

        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Enemy(int id, string name, int health, int maxHealth, short str, short def) : base (id, name, health, maxHealth)
        {
            Strength = str;
            Defense = def;
        }
        public Enemy(Enemy en) : base(en.ID, en.Name, en.Health, en.MaxHealth)
        {
            Strength = en.Strength;
            Defense = en.Defense;
        }
    }
}
