﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Models.Characters
{
    class Healer:Character,IHeal
    {

        private const int HealerHealthPoints = 75;
        private const int HealerDefensePoints = 50;
        private const int HealerHealingPoints = 60;
        private const int HealerRange = 6;

        public Healer(string id, int x, int y,Team team)
            : base(id, x, y, HealerHealthPoints, HealerDefensePoints, team, HealerRange)
        {
            this.HealingPoints = HealerHealingPoints;
        }


        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .Where(x => x.IsAlive && x != this)
                .OrderBy(x => x.HealthPoints)
                .FirstOrDefault(x => x.Team == this.Team);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealingPoints += item.HealthEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealingPoints -= item.HealthEffect;
            base.RemoveItemEffects(item);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
