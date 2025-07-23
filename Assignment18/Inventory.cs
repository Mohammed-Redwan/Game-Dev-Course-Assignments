using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public List<string> list = new List<string>();

    public void ShowItems() {
        for(int i = 0; i < list.Count; i++) {
            Debug.Log(list[i]);
        }
    }

    public void AddItem(string item) {
        this.list.Add(item);
    }
    public void AddItems(List<string> list) {
        this.list.AddRange(list);
    }
    
    public static List<string> operator +(Inventory i1, Inventory i2) {
        List<string> combineList = new List<string>();
        // combineList = i1.list.AddRange(i2.list);
        combineList.AddRange(i1.list);
        combineList.AddRange(i2.list);
        return combineList;
    }
}
