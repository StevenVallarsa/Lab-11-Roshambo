using System;
using System.Collections.Generic;

namespace Lab_13_Roshambo
{
    abstract class Player
    {
        public Validator v = new Validator();

        public string Name { get; set; }
        public List<string> Roshambo { get; set; }
        public List<string> roshamboValues = new List<string>() { "Rock", "Paper", "Scissors" };
        public List<int> userRecord = new List<int>() { 0, 0, 0 };

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract string GenerateRoshambo();

    }
}
