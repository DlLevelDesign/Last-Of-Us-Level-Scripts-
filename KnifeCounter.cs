using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeCounter : MonoBehaviour
{

    public int numOfKnives;
    public Text knives;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        knives.text = "KNIVES " + numOfKnives;

        if(numOfKnives <= 0)
        {
            numOfKnives = 0;
        }
    }
}
