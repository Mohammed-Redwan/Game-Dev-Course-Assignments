using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Multiply(int first, int secend) {
            return first * secend;
        }
        for(int i = 1; i <= 10; i++) {
            Debug.Log(Multiply(i ,5));
        }
    }

}
