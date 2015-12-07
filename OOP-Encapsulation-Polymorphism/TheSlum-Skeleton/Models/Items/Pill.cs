using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models.Items
{
    class Pill:Bonus
    {
        private const int PillHealthEffect = 100;
        private const int PillDefenseEffect = 0;
        private const int PillAttackEffect = 0;

        public Pill(string id)
            : base(id, PillHealthEffect, PillDefenseEffect, PillAttackEffect)
        {
            this.Timeout = 1;
            this.Countdown = 1;
            this.HasTimedOut = false;
        }
    }
}
