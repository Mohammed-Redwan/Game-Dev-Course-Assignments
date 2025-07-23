using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManege : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player firstPlayer = new Player();
        firstPlayer.InshalizePlayer(23, "mohmmed");
        Player secondPlayer = new Player();
        secondPlayer.InshalizePlayer(24, "Mohmmed");
        firstPlayer.Heal(23);
        firstPlayer.FullRestore(true);
        firstPlayer.ShowPlayersCount();

        
    }

    
}
