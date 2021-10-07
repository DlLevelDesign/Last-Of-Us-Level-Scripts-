using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*displays the text for picking up an item */
/*works with KnifePickUpTrigger.cs, MedKit.cs, PistolAmmo.cs*/

public class PressCUi : MonoBehaviour
{
    //bool for if the player is in a trigger or not 
    //is public so other scripts can alter the value
    public bool isInTrigger;
    //the text object that will display the text 
    public Text pressC;
    
    void Start()
    {
        //set the text to be blank so nothing is appearing on the screen 
        pressC.text = "";
    }

    void Update()
    {
        //if true change the text
        if(isInTrigger == true)
        {
            pressC.text = "Press C to pick up item";
        }
        
        //if false change the text to be blank
        if(isInTrigger == false)
        {
            pressC.text = "";
        }
    }
}
