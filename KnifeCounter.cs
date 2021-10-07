using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*track the number of knifes the player has*/
public class KnifeCounter : MonoBehaviour
{
    //the number of knives the player currently has
    public int numOfKnives;
    //the text displaying the current amount of knives 
    public Text knives;

    // Update is called once per frame
    void Update()
    {
        //display the word KNIVES and the current number of knives
        knives.text = "KNIVES " + numOfKnives;
        
        //if the amount of knives ever reaches 0 or below0 set the number of knives to 0
        if(numOfKnives <= 0)
        {
            numOfKnives = 0;
        }
    }
}
