using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        /// <summary>
        /// Class properties
        /// </summary>
        public override int Value { get; }
        public int AttackPower { get; }
        public int XP { get; set; }
        public override int Health { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="mov">Unit movement</param>
        /// <param name="health">Unit health</param>
        /// <param name="attackPower">Unit attack power</param>
        /// <param name="xp">Unit experience</param>
        public MilitaryUnit(int mov, int health, int attackPower, int xp) : base(mov, health)
        {
            Health = health + xp;
            AttackPower = attackPower;
            Value = attackPower + xp;
            XP = xp;
        }

        /// <summary>
        /// Attacks another unit
        /// </summary>
        /// <param name="u">Unit to attack</param>
        public void Attack(Unit u) { }

        public override string ToString()
        {
            return base.ToString() + $" {AttackPower} attack power {XP} xp";
        }
    }
}