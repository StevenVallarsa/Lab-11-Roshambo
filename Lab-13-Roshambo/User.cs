using System;
namespace Lab_13_Roshambo
{
    class User : Player
    {
        public User()
        {

        }

        public override string GenerateRoshambo()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name}, choose your weapon!");
            Console.WriteLine();

            for (int i = 0; i < roshamboValues.Count; i++)
            {
                Console.WriteLine($"  {i + 1} - {roshamboValues[i]}");
            }

            Console.WriteLine();
            Console.Write("What is your choice? (1, 2 or 3) ");

            string input = Console.ReadLine();

            // NEEDS VALIDATION FIRST

            if (input == "1")
            {
                return roshamboValues[0];
            }
            else if (input == "2")
            {
                return roshamboValues[1];
            }
            else
            {
                return roshamboValues[2];
            }

        }
    }
}
