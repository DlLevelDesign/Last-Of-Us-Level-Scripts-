using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    bool isOn = false;

    public GameObject flashlight;

    public int timer = 5;
     int countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timer;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        countdown = countdown - 1;
        

        if(countdown == 30)
        {
            isOn = false;
        }

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

        if (isOn == true)
        {
            flashlight.SetActive(true);
        }
        if(isOn == false)
        {
            flashlight.SetActive(false);
        }
    }
}
