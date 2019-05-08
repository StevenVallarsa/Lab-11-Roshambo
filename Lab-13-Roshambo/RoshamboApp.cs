using System;

namespace Lab_13_Roshambo
{
    public class RoshamboApp
    {
        public string Name { get; set; }

        public RoshamboApp()
        {
        }

        public void Run()
        { 
            Console.Clear();
            Console.WriteLine("Welcome to the wonderful world of Roshambo.");
            Console.WriteLine();
            Console.Write("What's your name? ");

            Name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Hello {Name}. Who would you like to play against?");
            Console.WriteLine();
            Console.WriteLine("  1) Rocky");
            Console.WriteLine("     or");
            Console.WriteLine("  2) Bullwinkle");
            Console.WriteLine();


            string input = "";
            bool run = true;

            while (run)
            {
                Console.Write("1 or 2? ");
                input = Console.ReadLine();

                Validator v = new Validator();

                if (v.TheValidator(input, 2))
                {
                    Console.WriteLine("Oops. I didn't understand that.");
                    Console.WriteLine();
                }
                else
                {
                    run = false;
                }

            }

            string oppAttack = "";
            string opponent = "";
            Rocky rocky = new Rocky();
            Bullwinkle bw = new Bullwinkle();

            if (input == "1")
            {
                oppAttack = rocky.GenerateRoshambo();
                opponent = "Rocky";
            }
            else
            {
                oppAttack = bw.GenerateRoshambo();
                opponent = "Bullwinkle";
            }

            User u = new User();
            string userAttack = u.GenerateRoshambo();

            Console.WriteLine();
            Console.WriteLine($"  {opponent} threw {oppAttack}");
            Console.WriteLine($"  You threw {userAttack}");

            string winner = CheckThrows(oppAttack, userAttack);

            if (winner == "It's a draw!")
            {
                u.userRecord[2] += 1;

                if (opponent == "Rockey")
                {
                    rocky.oppRecord[2] += 1;
                }
                else
                {
                    bw.oppRecord[2] += 1;
                }
            }
            else if (winner == "You win!")
            {
                u.userRecord[0] += 1;

                if (opponent == "Rockey")
                {
                    rocky.oppRecord[1] += 1;
                }
                else
                {
                    bw.oppRecord[1] += 1;
                }
            }
            else
            {
                u.userRecord[1] += 1;

                if (opponent == "Rockey")
                {
                    rocky.oppRecord[0] += 1;
                }
                else
                {
                    bw.oppRecord[0] += 1;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Your record aginst {opponent} is now:");
            Console.WriteLine();
            Console.WriteLine($"{u.userRecord[0]} Wins, {u.userRecord[1]} Losses, and {u.userRecord[2]} Draws");
            Console.WriteLine();
            Console.WriteLine($"{(input == "1" ? rocky.oppRecord[0] : bw.oppRecord[0])} Wins, {(input == "1" ? rocky.oppRecord[1] : bw.oppRecord[1])} Losses, and {(input == "1" ? rocky.oppRecord[2] : bw.oppRecord[2])} Draws");

        }

        public string CheckThrows(string oppAttack, string userAttack)
        {

            if (oppAttack == userAttack)
            {
                return "It's a draw!";
            }
            else if ( (oppAttack == "Rock" && userAttack == "Paper") ||
                (oppAttack == "Paper" && userAttack == "Scissors") ||
                (oppAttack == "Scissors" && userAttack == "Rock") )
            {

                return "You win!";
            }
            else
            {
                return "You lose!";
            }
        }

    }

}
