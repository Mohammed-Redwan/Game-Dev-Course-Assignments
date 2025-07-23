using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass18
{
    public class GameInventory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Inventory i1 = new Inventory();
            i1.AddItem("Healing Postion");
            i1.AddItem("Strength Postion");

            Inventory i2 = new Inventory();
            i1.AddItem("Elixir");
            i1.AddItem("Dark Elixir");

            List<string> combineList = (i1 + i2);

            Inventory combineInventory = new Inventory();
            combineInventory.AddItems(combineList);

            combineInventory.ShowItems();


        }

    }
}