using System.Numerics;

namespace GameUnits
{
    /// <summary>
    /// Abstract class so it can't be instantiated
    /// </summary>
    public abstract class Unit
    {
        /// <summary>
        /// Class variables
        /// </summary>
        private int movement;

        /// <summary>
        /// Class properties
        /// </summary>
        public virtual int Health { get; set; }
        public abstract float Value { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="movement">Unit movement</param>
        /// <param name="health">Unit health</param>
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        /// <summary>
        /// Moves the unit
        /// </summary>
        /// <param name="v">Distance to move (Vector2)</param>
        public void Move(Vector2 v)
        {
            Console.WriteLine($"The unity moved {v.X} houses horizontally" +
            $" and {v.Y} houses vertically.");
        }

        /// <summary>
        /// Overrides method ToString() to return unit's health and value
        /// </summary>
        public override string ToString()
        {
            return $"{Health} health {Value} value";
        }
    }
}