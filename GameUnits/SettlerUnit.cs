using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        /// <summary>
        /// Class properties
        /// </summary>
        public override float Value { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="mov">Unit movement</param>
        /// <param name="health">Unit health</param>
        /// <returns></returns>
        public SettlerUnit(int mov, int health) : base(mov, health)
        {
            Value = 5;
        }
    }
}