using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Slowly fades the screen to black when the player enters the safe house at the end of the level*/
public class FadeToBlack : MonoBehaviour
{
    //the object that will be faded over the camera
    GameObject blackIMG;
    //bool for if the player has entered the trigger or not 
    bool enteredTrigger = false;
    //i dont think this is used 
    Color invisBlack;
    //dont think this is used either 
    float alpha = 0f;
    
    void Start()
    {
        //assign this to the panel object in engine 
        blackIMG = GameObject.Find("Panel");
        //set the transparency to fully transparent 
        blackIMG.GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }

    //using FUpdate for consistentcy
    void FixedUpdate()
    {
        //if the player enters the trigger increase the transparency by .05 every frame
        if(enteredTrigger == true)
        {
            blackIMG.GetComponent<Image>().color = new Color(0, 0, 0, alpha += .05f);
        }
    }

    //if the the player enters the trigger set enteredTrigger to true
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enteredTrigger = true;
        }
    }
}
