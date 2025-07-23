using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14 {
    public class Player14 : Character
    {
        public Player14(string name, int health) : base(name, health){
            
        }
        public void Heal(int healAmount) {
            this.SetHealth(healAmount + this.health);
        }
    }
}