using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Functionality for what happens to an individual ammo pickup found in the level*/ 
public class PistolAmmo : MonoBehaviour
{
    //ammount of ammo given to the player when they find the pistol ammo pickup
    public int = 1;
 
    private GameObject player;
    private bool playerIsInTrigger = false;

    void Start()
    {
        //assign the player variable to the gameobject with the Player tag
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //if the player enters the trigger activate the presscui
        if(playerIsInTrigger == true)
        {
            player.GetComponent<PressCUi>().isInTrigger = true;
        }
        
        //if the player enters the trigger and hits the C key then added the loadedAmmo var from the PistolAmmoCounter script to the AmmoAmount var
        //deactivate presscui
        //deactivate this object 
        if(playerIsInTrigger == true && Input.GetKeyDown(KeyCode.C))
        {
            player.GetComponent<PistolAmmoCounter>().loadedAmmo += AmmoAmount;
            player.GetComponent<PressCUi>().isInTrigger = false;
            this.transform.parent.gameObject.SetActive(false);
        }
    }

    //if the player enters the trigger set the playerIsinTrigger to true 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerIsInTrigger = true;
        }
    }

    //if the player exits the trigger set the playerIsinTrigger to false
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIsInTrigger = false;
            player.GetComponent<PressCUi>().isInTrigger = false;
        }
    }
}
