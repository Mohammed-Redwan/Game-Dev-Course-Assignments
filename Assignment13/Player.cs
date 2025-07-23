using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    static int playersNum = 0;
    public int health;
    public string name;
    
    public void InshalizePlayer(int health, string name) {
        this.name = name;
        this.health = health;
        playersNum++;
    }


    public void Heal (int healAmount) {
        this.health += healAmount;
        Debug.Log(this.health);
    }

    public void FullRestore(bool full) {
        if(full) {
            this.health = 100;
            Debug.Log(this.name + " " + " has full health");
        }
        
    }
    public void ShowPlayersCount(){
        Debug.Log(playersNum);
    }
    
}
   
