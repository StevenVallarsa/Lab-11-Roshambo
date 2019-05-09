using System;

namespace Lab_13_Roshambo
{
    public class RoshamboApp
    {
        public string Name { get; set; }
        Validator v = new Validator();

        public RoshamboApp()
        {
        }

        public void Run()
        {

            Console.WriteLine("Welcome to the wonderful world of Roshambo.");
            Console.WriteLine();
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            User user = new User(name);

            Player opponent; // object holder for whichever opponent is chosen
            bool run = true;

            while(run)
            {
                Console.WriteLine();
                Console.WriteLine($"{name}, who would you like to play against?");
                Console.WriteLine();
                Console.WriteLine("  1) Rocky");
                Console.WriteLine("     or");
                Console.WriteLine("  2) Bullwinkle");
                Console.WriteLine();


                string input = "";
                bool run2 = true;

                while (run2)
                {
                    Console.Write("1 or 2? ");
                    input = Console.ReadLine();

                    if (!v.TheValidator(input, 2))
                    {
                        Console.WriteLine("I'm sorry. I didn't understand that.");
                        Console.WriteLine();
                    }
                    else
                    {
                        run2 = false;
                    }

                }

                string oppAttack = "";

                if (input == "1")
                {
                    opponent = new Rocky("Rocky");
                }
                else
                {
                    opponent = new Bullwinkle("Bullwinkle");
                }


                oppAttack = opponent.GenerateRoshambo();

                string userAttack = user.GenerateRoshambo();

                Console.WriteLine();
                Console.WriteLine($"  {opponent.Name} threw {oppAttack}");
                Console.WriteLine($"  You threw {userAttack}");

                string winner = CheckThrows(oppAttack, userAttack);

                if (winner == "It's a draw!")
                {
                    user.userRecord[2] += 1;
                    opponent.userRecord[2] += 1;
                }
                else if (winner == "You win!")
                {
                    user.userRecord[0] += 1;
                    opponent.userRecord[1] += 1;
                }
                else
                {
                    user.userRecord[1] += 1;
                    opponent.userRecord[0] += 1;
                }

                Console.WriteLine();
                Console.WriteLine($"Your record is now {user.userRecord[0]} Win{(user.userRecord[0] == 1 ? "" : "s")}, {user.userRecord[1]} Loss{(user.userRecord[1] == 1 ? "" : "es")}, and {user.userRecord[2]} Draw{(user.userRecord[2] == 1 ? "" : "s")}");
                Console.WriteLine();

                run2 = true;
                while (run2)
                {
                    Console.Write("Would you like to play again? (y/n) ");
                    string inputYN = Console.ReadLine().ToLower();

                    if (!v.TheValidator(inputYN, 1))
                    {
                        Console.WriteLine("I'm sorry, I didn't undertand that.");
                    }
                    else
                    {
                        run2 = false;

                        if (inputYN[0] == 'n')
                        {
                            run = false;
                        }
                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine("Goodbye.");
        }


        //method to check for win, loss or tie
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
