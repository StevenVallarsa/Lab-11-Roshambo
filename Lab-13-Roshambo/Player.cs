using System;
using System.Collections.Generic;

namespace Lab_13_Roshambo
{
    abstract class Player
    {
        public string Name { get; set; }
        public List<string> Roshambo { get; set; }
        public List<string> roshamboValues = new List<string>() { "Rock", "Paper", "Scissors" };
        public Random r = new Random();
        public List<int> userRecord = new List<int>() { 0, 0, 0 };
        public List<int> oppRecord = new List<int>() { 0, 0, 0 };

        public Player()
        {
        }

        public abstract string GenerateRoshambo();

    }
}
