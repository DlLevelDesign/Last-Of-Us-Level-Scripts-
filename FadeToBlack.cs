using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeToBlack : MonoBehaviour
{

    GameObject blackIMG;
    bool enteredTrigger = false;
    Color invisBlack;
    float alpha = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        blackIMG = GameObject.Find("Panel");
        blackIMG.GetComponent<Image>().color = new Color(0, 0, 0, 0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(enteredTrigger == true)
        {
            blackIMG.GetComponent<Image>().color = new Color(0, 0, 0, alpha += .05f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enteredTrigger = true;
        }
    }
}
