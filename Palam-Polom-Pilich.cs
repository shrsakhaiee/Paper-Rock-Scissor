using System;

namespace Palam_Polom_Pilich
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int computer1_score = 0, computer2_score = 0, user_score = 0, index, index1;
            string computer1_choice, computer2_choice, user_choice;

            string[] options = new string[2];
            options[0] = "Behind";
            options[1] = "Forth";

            while (true)
            {
                index = r.Next(0, 2);
                index1 = r.Next(0, 2);
                computer1_choice = options[index];
                computer2_choice = options[index1];

                user_choice = Console.ReadLine();
                Console.WriteLine("computer1: {0:X}", computer1_choice);
                Console.WriteLine("computer2: {0:X}", computer2_choice);

                if (computer1_choice == computer2_choice && user_choice != computer1_choice)
                {
                    user_score++;
                }
                else if (computer1_choice == user_choice && computer2_choice != computer1_choice)
                {
                    computer2_score++;
                }
                else if (computer2_choice == user_choice && computer1_choice != computer2_choice)
                {
                    computer1_score++;
                }
                if (user_score == 5)
                {
                    Console.WriteLine("You Win😍😍");
                    break;
                }
                else if (computer1_score == 5)
                {
                    Console.WriteLine("Computer1 Win");
                    break;
                }
                else if (computer2_score == 5)
                {
                    Console.WriteLine("Computer2 Win");
                    break;
                }
            }

            Console.WriteLine("payan✋");
        }
    }
}
