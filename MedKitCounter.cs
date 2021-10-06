using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedKitCounter : MonoBehaviour
{

    public int numOfMedKits;
    public float medkitHealAmmount;

    public Text medkitText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(numOfMedKits > 0)
            {
                this.GetComponent<CoverShooter.CharacterHealth>().Health += medkitHealAmmount;
                numOfMedKits -= 1;
            }
        }

        if(numOfMedKits < 0)
        {
            numOfMedKits = 0;
        }

        medkitText.text = "MEDKITS " + numOfMedKits;

    }
}
