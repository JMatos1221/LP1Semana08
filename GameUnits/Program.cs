using System.Numerics;

namespace GameUnits // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Object instantiation
            /// </summary>
            MilitaryUnit militaryUnit = new MilitaryUnit(5, 5, 5, 5);
            SettlerUnit settlerUnit = new SettlerUnit(2, 2);

            /// <summary>
            /// Moving military and settler units
            /// </summary>
            militaryUnit.Move(new Vector2(5, 5));
            settlerUnit.Move(new Vector2(2, 2));

            /// <summary>
            /// Printing both units value and health and ToString() methods
            /// </summary>
            Console.WriteLine($"Military Unit has {militaryUnit.Value} " +
            $"value and {militaryUnit.Health} health.");

            Console.WriteLine($"Settler Unit has {settlerUnit.Value} " +
            $"value and {settlerUnit.Health} health.");

            Console.WriteLine(militaryUnit.ToString());

            Console.WriteLine(settlerUnit.ToString());
        }
    }
}