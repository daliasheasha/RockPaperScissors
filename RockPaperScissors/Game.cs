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
                if (string.IsNullOrWhiteSpace(userInput) || (GetPlayChoice(userInput) is Choice playerChoice && playerChoice == Choice.Invalid))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid option!");
                    continue;
                }

                Choice computerChoice = (Choice)new Random().Next(0, 3); // Last Enum choice is Invalid

                Console.WriteLine("\nYour choice: " + playerChoice);
                Console.WriteLine("Computer choice: " + computerChoice);

                if (playerChoice == computerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                         (playerChoice == Choice.Paper && computerChoice == Choice.Rock) ||
                         (playerChoice == Choice.Scissors && computerChoice == Choice.Paper))
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
        public static Choice GetPlayChoice(string userInput)
        {
            var playerChoice = userInput switch
            {
                "rock" or "r" => Choice.Rock,
                "paper" or "p" => Choice.Paper,
                "scissors" or "s" => Choice.Scissors,
                _ => Choice.Invalid,
            };
            return playerChoice;
        }
        public enum Choice
        {
            Rock,
            Paper,
            Scissors,
            Invalid
        }
    }
}