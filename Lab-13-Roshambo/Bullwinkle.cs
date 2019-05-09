using System;

namespace Lab_13_Roshambo
{
    class Bullwinkle : Player
    {
        public Bullwinkle(string Name) : base(Name)
        {
        }

        public Random r = new Random();

        public override string GenerateRoshambo()
        {
            return roshamboValues[r.Next(0,3)];
        }
    }
}
