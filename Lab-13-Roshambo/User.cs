using System;
namespace Lab_13_Roshambo
{
    class User : Player
    {
        public User(string Name) : base(Name)
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

            string input = "";
            bool run = true;
            while (run)
            {
                Console.Write("What is your choice? (1, 2 or 3) ");
                input = Console.ReadLine();

                if (!v.TheValidator(input, 3))
                {
                    Console.WriteLine("Oops. I didn't understand that.");
                    Console.WriteLine();
                }
                else
                {
                    run = false;
                }

            }

            // with validation, 'input' can only be "1", "2" or "3"
            if (input == "1")
            {
                return RPS.Rock;
            }
            else if (input == "2")
            {
                return RPS.Paper;
            }
            else
            {
                return RPS.Scissors;
            }

        }
    }
}
