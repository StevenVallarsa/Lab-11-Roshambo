using System;

namespace Lab_13_Roshambo
{
    public class Validator
    {
        public Validator()
        {
        }

        public bool TheValidator(string input, int qty)
        {
            // to validate yes / no answers
            if (qty == 1)
            {
                if (input[0] == 'y' || input[0] == 'n')
                {
                    return true;
                }
                return false;
            }

            // to valdiate 1 / 2 answers
            if (qty == 2)
            {
                if (input == "1" || input == "2")
                {
                    return true;
                }
                return false;

            }

            // to validate 1 / 2 / 3 answers
            if (qty == 3)
            {
                if (input == "1" || input == "2" || input == "3")
                {
                    return true;
                }
                return false;
            }

            return false; // here to prevent 'not all code paths return a value' error


        }


    }
}
