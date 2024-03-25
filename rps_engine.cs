using System;

namespace RockPaperScissors
{
    class RPSEngine
    {
        public static int RandomOneToThree()
        {
            Random pick = new Random();
            return pick.Next(1, 4);
        }
        public static string ComputerSelects(int randomNumber)
        {
            string selection;
            switch (randomNumber)
            {
                case 1:
                    selection = "Rock";
                    break;
                case 2:
                    selection = "Rock";
                    break;
                case 3:
                    selection = "Paper";
                    break;
                default:
                    return "ERROR";
            }
            return selection;
        }
        public static string WinOrLoss(string Player, string Computer)
        {
            if (Player == "Rock")
            {
                if (Computer == "Rock") { return "draw"; }
                else if (Computer == "Paper") { return "lose"; }
                else { return "win"; }
            } else if (Player == "Paper")
            {
                if (Computer == "Rock") { return "win"; }
                else if (Computer == "Paper") { return "draw"; }
                else { return "lose"; }
            } else {
                if (Computer == "Rock") { return "lose"; }
                else if (Computer == "Paper") { return "win"; }
                else { return "draw"; }
            }
        }
    }
}