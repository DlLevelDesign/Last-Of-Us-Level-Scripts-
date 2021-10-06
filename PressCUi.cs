using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressCUi : MonoBehaviour
{

    public bool isInTrigger;
    public Text pressC;

    // Start is called before the first frame update
    void Start()
    {
        pressC.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(isInTrigger == true)
        {
            pressC.text = "Press C to pick up item";
        }

        if(isInTrigger == false)
        {
            pressC.text = "";
        }
    }
}
