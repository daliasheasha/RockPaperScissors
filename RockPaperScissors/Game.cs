namespace RockPaperScissors
{
    public class Game
    {
        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's play Rock, Paper, Scissors!\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter a choice from the following: (r)ock, (p)aper, (s)cissors");

                Console.ForegroundColor = ConsoleColor.White;
                string? userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please enter a valid option!");
                    continue;
                }


                Tool playerChoice = SetPlayChoice(userInput);
                if (playerChoice == Tool.Invalid)
                {
                    Console.WriteLine("Please enter a valid option!");
                }
                Tool computerChoice = (Tool)new Random().Next(0, 3);

                Console.WriteLine("\nYour choice: " + playerChoice);
                Console.WriteLine("Computer choice: " + computerChoice);

                if (playerChoice == computerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == Tool.Rock && computerChoice == Tool.Scissors) ||
                         (playerChoice == Tool.Paper && computerChoice == Tool.Rock) ||
                         (playerChoice == Tool.Scissors && computerChoice == Tool.Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins!");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDo you want to play again? [y/n]");
                string? reply = Console.ReadLine();
                if (reply != null && reply.ToLower().Equals("n"))
                {
                    break;
                }
            }
        }
        public static Tool SetPlayChoice(string userInput)
        {
            Tool playerChoice;
            switch (userInput)
            {
                case "rock":
                case "r":
                    playerChoice = Tool.Rock;
                    break;
                case "paper":
                case "p":
                    playerChoice = Tool.Paper;
                    break;
                case "scissors":
                case "s":
                    playerChoice = Tool.Scissors;
                    break;
                default:
                    playerChoice = Tool.Invalid;
                    break;

            }
            return playerChoice;
        }
        public enum Tool
        {
            Rock,
            Paper,
            Scissors,
            Invalid
        }
    }
}