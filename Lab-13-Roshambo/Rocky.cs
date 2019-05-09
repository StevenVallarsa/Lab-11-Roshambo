using System;

namespace Lab_13_Roshambo
{
    class Rocky : Player
    {
        public Rocky(string Name) : base(Name)
        { 
        }

        public override string GenerateRoshambo()
        {
            return RPS.Rock;
        }
    }
}
