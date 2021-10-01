using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*turns light on and off to simulate flickering effect*/
/*A fast and dirty script made to get functionality quickly, with more time I would have made it more dynamic*/
public class FlickeringLight : MonoBehaviour
{
    //is light on 
    bool isOn = false;

    public GameObject flashlight;
    
    //the countdown timer starts at 125  
    int countdown = 125;

    //using fixedupdate for consistency 
    void FixedUpdate()
    {
        //subtract 1 from countdown every frame 
        countdown = countdown - 1;
        
        //if countdown equals 30 set isOn to false 
        if(countdown == 30)
        {
            isOn = false;
        }
        
        //if countdown equals 25 set isOn to true
        if (countdown == 25)
        {
            isOn = true;
        }

        if (countdown == 20)
        {
            isOn = false;
        }

        if (countdown == 15)
        {
            isOn = true;
        }

        if (countdown <= 0)
        {
            isOn = true;
            countdown = timer;
        }
        
        //if isOn is true turn the light on
        if (isOn == true)
        {
            flashlight.SetActive(true);
        }
        //if isOn is false turn the light off
        if(isOn == false)
        {
            flashlight.SetActive(false);
        }
    }
}
