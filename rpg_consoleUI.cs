namespace RockPaperScissors
{
    class RPS_UI
    {
        public void Start()
        {
            int randomNumber = RPSEngine.RandomOneToThree();
            string computerChoice = RPSEngine.ComputerSelects(randomNumber);
            string result = "";

            Console.WriteLine("Welcome to Rock Paper Scissors. Choose:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");

            int playerChoice = int.Parse(Console.ReadLine());
            switch (playerChoice)
            {
                case 1:
                    result = RPSEngine.WinOrLoss("Rock", computerChoice);
                    break;
                case 2:
                    result = RPSEngine.WinOrLoss("Paper", computerChoice);
                    break;
                case 3:
                    result = RPSEngine.WinOrLoss("Scissors", computerChoice);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid selection.");
                    Start();
                    break;
            }
            
            switch (result)
            {
                case "win":
                    Console.WriteLine();
                    Console.WriteLine("Computer selected: " + computerChoice + ". You win!");
                    break;
                case "lose":
                    Console.WriteLine();
                    Console.WriteLine("Computer selected: " + computerChoice + ". You lose!");
                    break;
                case "draw":
                    Console.WriteLine();
                    Console.WriteLine("Computer selected: " + computerChoice + ". It's a draw!");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Something went wrong.");
                    break;
            }
        }
    }
}