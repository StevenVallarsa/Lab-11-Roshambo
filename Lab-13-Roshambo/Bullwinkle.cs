using System;
namespace Lab_13_Roshambo
{
    class Bullwinkle : Player
    {

        public Bullwinkle()
        {
        }

        public override string GenerateRoshambo()
        {
            return roshamboValues[r.Next(0,3)];
        }
    }
}
