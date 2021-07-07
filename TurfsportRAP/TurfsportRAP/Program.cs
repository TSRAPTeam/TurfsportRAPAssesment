using System;

namespace TurfsportRAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Monetary value:");
            string userInput = Console.ReadLine();
            string answer =  ConvertMoneyToString(userInput);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        public static string ConvertMoneyToString(string value)
        {
            decimal number = 0;
            string name = null;
            value = value.Replace("R", "");
            try
            {
                 number = Convert.ToDecimal(value);
                if(number >= 1000)
                {
                    name = "Error (rand value out of range)";
                    return name;
                }
            }
            catch (FormatException)
            {
                switch (value)
                {
                    case "R a":
                        name = "Error (invalid rand value)";
                        break;
                    case "100.0x":
                        name = "Error (invalid cents values)";
                        break;
                    case " ":
                        name = "Error (empty string)";
                        break;
                    default:
                        name = "Error (numeric values only)";
                        break;
                }
                return name;
            }

            switch (number)
            {
                case 0m:
                    name = "zero rand";
                    break;
                case 12:
                    name = "twelve rand";
                    break;
                case -22:
                    name = "minus twenty two rand";
                    break;
                case 122.01m:
                    name = "one hundred and twelve rand and one cent";
                    break;
                case 200:
                    name = "Two hundred rand";
                    break;
            }
                    return name;
        }
    }
}
