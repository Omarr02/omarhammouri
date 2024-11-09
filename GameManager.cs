using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Player One", 80);
        player2.InitializePlayer("Player Two", 60);
        player1.Heal(10); 
        player2.Heal(true); 
        Player.ShowPlayerCount();
    }
}
