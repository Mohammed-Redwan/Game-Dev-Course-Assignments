using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14 {
    public class Enemy : Character
    {
        public Enemy(string name, int health) : base(name, health) {
            
        }
        public void Attack(Character chara, int damage) {
            chara.SetHealth(-damage);
            Debug.Log(chara.health);
        }
    }
}