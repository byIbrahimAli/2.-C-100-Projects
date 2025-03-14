using P3_RPGBattleSimulatorOOP.Models;

namespace P3_RPGBattleSimulatorOOP;

public class Game
{
    public GameWinner DetermineWinner(int playerHealth, int opponentHealth)
    {
        if (playerHealth == 0 && opponentHealth == 0)
        {
            return GameWinner.Tie;
        } else if (playerHealth > 0 && opponentHealth == 0)
        {
            return GameWinner.Player;
        } else if (playerHealth == 0 && opponentHealth > 0)
        {
            return GameWinner.Opponent;
        }
        else
        {
            return GameWinner.GameInProgress;
        }
    }
}