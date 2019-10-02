namespace RockPaperScissorsKata
{
    public class Game
    {
        public Game()
        {
        }

        public string Play(Move playerMove, Move opponentMove)
        {
            if (playerMove == Move.Paper)
            {
                if (opponentMove == Move.Scissors)
                {
                    return "Player Loses";
                }
            }

            if (opponentMove == playerMove)
            {
                return "Tie";
            }


            
            if (playerMove == Move.Rock)
            {
                if(opponentMove == Move.Paper)
                {
                    return "Player Loses";
                }
                return "Player Wins";
            }



            return "Player Wins";
        }
    }
}
