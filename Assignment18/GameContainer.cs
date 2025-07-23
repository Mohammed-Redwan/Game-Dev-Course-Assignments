using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass18 {
    public class GameContainer<T>
    {
        private string s;
        private T item;
        
        public void SetItem(T item) {
            this.item = item;
        }
        public T GetItem() {
            return this.item;
            
        }
    }
}
