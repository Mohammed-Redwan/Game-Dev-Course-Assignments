using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    namespace ass18 {
    public class GameUtils 
    {
        public static string DescribeItem<T>(T somthing) {
            return "this item is " + somthing;
        }
    }
}