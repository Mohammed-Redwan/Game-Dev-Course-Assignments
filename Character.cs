using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass14 {
    public class Character {
        public string name;
        public int health;

        public Character(string name, int health) {
            this.SetHealth(health);
            
        }
        public void SetName(string name) {
            this.name = name;
        }
        public string GetName() {
            return this.name;
        }
        
        public void SetHealth(int health) {
            if(health > 100) {
                this.health = 100;
            } else if (health < 0) {
                this.health = 0;
            } else {
                this.health = health;
            }
        
        }
        public int GetHealth(int health) {
            return this.health;
        }
    }
}
    
