using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmo : MonoBehaviour
{
    public int AmmoAmount = 1;
 

    private GameObject player;
    private bool playerIsInTrigger = false;

 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
       
    }

    // Update is called once per frame
    void Update()
    {

        //print(playerPistol);
        if(playerIsInTrigger == true)
        {
            player.GetComponent<PressCUi>().isInTrigger = true;
        }

        if(playerIsInTrigger == true && Input.GetKeyDown(KeyCode.C))
        {
            player.GetComponent<PistolAmmoCounter>().loadedAmmo += AmmoAmount;
            player.GetComponent<PressCUi>().isInTrigger = false;
            this.transform.parent.gameObject.SetActive(false);
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerIsInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIsInTrigger = false;
            player.GetComponent<PressCUi>().isInTrigger = false;
        }
    }
}