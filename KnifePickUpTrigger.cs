using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*trigger that allows the player to add a knife to their inventory*/
public class KnifePickUpTrigger : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //assign the player variable to the gameobject with the tag Player 
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay(Collider other)
    {   
        //if the player enters the trigger turn on presscui
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<PressCUi>().isInTrigger = true;
            //if the player presses c in the trigger, add one knife to the current number of knives, turn off the presscui, and deactivate the parent of this object 
            if (Input.GetKeyDown(KeyCode.C))
            {
                player.GetComponent<KnifeCounter>().numOfKnives += 1;
                player.GetComponent<PressCUi>().isInTrigger = false;
                this.transform.parent.gameObject.SetActive(false);
            }
        }

    }
}
