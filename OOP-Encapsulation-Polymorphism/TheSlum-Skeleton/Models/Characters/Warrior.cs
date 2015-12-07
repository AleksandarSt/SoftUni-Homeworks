using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Models.Characters
{
    class Warrior:Character,IAttack
    {

        private const int WariorHealthPoints = 200;
        private const int WariorDefensePoints = 100;
        private const int WariorAttackPoints = 150;
        private const int WariorRange = 2;

        protected Warrior(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id,x,y,WariorHealthPoints,WariorDefensePoints,team,WariorRange)
        {
            this.AttackPoints = WariorAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(x => x.IsAlive).First(x => x.Team != this.Team);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
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
            return base.ToString() + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}
