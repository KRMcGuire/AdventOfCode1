using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    /// <summary>
    /// Let's overcomplicate this! Here's a class to represent elves.
    /// </summary>
    internal class Elf
    {
        /// <summary>
        /// The elf's food as an array of integers representing their calorie yields.
        /// </summary>
        public List<int> Food { get; set; }

        public Elf(List<int> Food) { 
            this.Food = Food;
        }

        /// <summary>
        /// Read in a text file of elf food inventories, where each food item is
        /// an integer on it's own line, and inventories are separated by blank lines.
        /// Produces a list of elves
        /// </summary>
        /// <param name="filePath">The path to the file to read in and convert to elves.</param>
        /// <returns>A list of elves</returns>
        public static List<Elf> MakeElves(string filePath)
        {
            var streamReader = new StreamReader(filePath);
            var elves = new List<Elf> { };
            var food = new List<int> { };
            String line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    elves.Add(new Elf(food));
                    food = new List<int> { };
                } else
                {
                    food.Add(Int32.Parse(line));
                }
            }

            return elves;
        }
    }
}
