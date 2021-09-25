using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Makes the plank the player is walking on fall 
//Causes the truck lights below the plank become active
//Temporarily change camera
//Opens the gate in front of the safe house
//Enables QuicklyThisWayText Gameobject 
//Spawns a horde of zombies 
//Turns off invisible railings so player doesnt collide with them anymore 
public class PlankFall : MonoBehaviour
{

    public GameObject plank;
    public GameObject gate;
    public GameObject headlight;
    public GameObject headlight1;
    public GameObject horde;
    public GameObject cargo;
    public GameObject sidecamera;
    public GameObject middleCamera;
    public GameObject[] railings;

    GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        //find corresponding text gameobject 
        dialogue = GameObject.Find("QuicklyThisWayText");
        dialogue.GetComponent<Text>().text = "";
    }

    //If the player enters the trigger temporarily disable the collision of the cargo crate it's is resting on so it falls and turn on headlights
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //disable cargo
            cargo.GetComponent<BoxCollider>().enabled = false;
            //turn off rigidbody constraints
            plank.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //turn on headlights
            headlight.SetActive(true);
            headlight1.SetActive(true);
            
            //disable invisible railings
            foreach(GameObject railing in railings)
            {
                railing.SetActive(false);
            }
            
            //turn off collision so player can't collide with it accidentally 
            this.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine(waiter());

        }
    }
     
    
    IEnumerator waiter()
    {
        //after 2 seconds open the gate, spawn zombie horde, and change camera to middle camera
        yield return new WaitForSeconds(2);
        gate.transform.Rotate(gate.transform.rotation.x, gate.transform.rotation.y + 90f, gate.transform.rotation.z);
        horde.SetActive(true);
        middleCamera.SetActive(true);
        
        //after 2 seconds, change camera to side camera, turn on dialogue text component, reactive cargo crate's collision 
        yield return new WaitForSeconds(2);
        middleCamera.SetActive(false);
        sidecamera.SetActive(true);
        dialogue.GetComponent<Text>().text = "Quickly, This Way!";
        cargo.GetComponent<BoxCollider>().enabled = true;
        
        //after 3 seconds clear the text, change to main camera, disable this component. 
        yield return new WaitForSeconds(3);
        dialogue.GetComponent<Text>().text = "";
        sidecamera.SetActive(false);
        this.enabled = false;
    }

}
