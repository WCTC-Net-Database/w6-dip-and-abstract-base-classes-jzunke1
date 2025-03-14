﻿namespace W6_assignment_template.Models
{
    public class Goblin : CharacterBase, ILootable
    {
        public string Treasure { get; set; }

        public Goblin(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} performs a goblin action!");
        }
    }

    public interface ILootable
    {
        string Treasure { get; set; }
    }
}
