using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*spawns an array of zombies when the player enters the trigger*/
public class ZombieTriggerSpawner : MonoBehaviour
{
    //the array of zombies to be spawned
    public GameObject[] zombies;

    void Start()
    {
        //deactivate every zombie in the zombie array on the first frame
        foreach(GameObject zombie in zombies)
        {
            zombie.SetActive(false);
        }
        
        //turn off the mesh renderer of this object (is used to help with placement in the editor)
        this.GetComponent<MeshRenderer>().enabled = false;
    }
    
    //if the player enters the trigger activate all of the zombies in the zombies array 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach (GameObject zombie in zombies)
            {
                zombie.SetActive(true);
            }
        }
    }
}
