// See https://aka.ms/new-console-template for more information
using AdventOfCode1;


var elves = Elf.MakeElves(".\\input.txt");

Console.WriteLine(elves.Max(elf => elf.Food.Sum()));
