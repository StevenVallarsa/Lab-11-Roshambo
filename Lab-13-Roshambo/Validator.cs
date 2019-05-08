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
            if (qty == 2)
            {
                if (input != "1" || input != "2")
                {
                    return false;
                }
                return true;

            }

            if (qty == 3)
            {
                if (input != "1" || input != "2" || input != "3")
                {
                    return false;
                }
                return true;
            }

            return true;


        }


    }
}
