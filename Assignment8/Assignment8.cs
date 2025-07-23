using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // first exr.
        int i = 0;
        while(i < 20) {
            int x = Random.Range(0, 20);
            if(x == 5) {
                continue;
            }
            if(x == 15) {
                break;
            }
            Debug.Log(x);
            i++;
        }
        Debug.Log("========================");
        //second exr.
        string[] words = {"cat", "dog", "car", "pizza", "hat", "fish", "tree", "monkey", "ball", "bird"};
        int i2 = 0;
        string sentence = "";
        while(i2 < 7) {
            int randomIndex = Random.Range(0, 10);
            if (i2 == 6) {
                sentence += words[randomIndex];
            } else {
                sentence += words[randomIndex] + " ";
            }
            
            i2++;
        }
        Debug.Log(sentence);
    }
}
