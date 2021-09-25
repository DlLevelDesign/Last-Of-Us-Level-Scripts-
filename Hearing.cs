using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*this script lets the player see enemy outlines when they are crouched and within a certain range*/
/*emulates the hearing mechanic from the Last Of US*/
public class Hearing : MonoBehaviour
{
    //Enemies that are within the range are added to this list 
    public List<GameObject> Enemies = new List<GameObject>();
   
    private GameObject player;


    void Start()
    {
        //find the player character 
        player = GameObject.FindGameObjectWithTag("Player");
    }

 
    void Update()
    {
        //if the player is crouching then highlight every enemy in the list
        if(player.GetComponent<CoverShooter.CharacterMotor>()._isCrouching == true)
        {
            foreach (GameObject Enemy in Enemies)
            {
                Enemy.GetComponent<Outline>().enabled = true;
            }
        }
        //if the player is not crouching then turn off the highlight 
        else if (player.GetComponent<CoverShooter.CharacterMotor>()._isCrouching == false)
        {
            foreach (GameObject Enemy in Enemies)
            {  
                    Enemy.GetComponent<Outline>().enabled = false;
                
            }
        }
    }

    //when an enemy enters the trigger then add them to the list 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Enemies.Add(other.gameObject);
        }


    }

    //when an enemy leaves the trigger remove them from the list and turn off their highlight
    private void OnTriggerExit(Collider other)
    {
        //may have to do something in update instead i got sidetracked and forgot 
        if (other.gameObject.tag == "Enemy")
        {
            Enemies.Remove(other.gameObject);
            other.gameObject.GetComponent<Outline>().enabled = false;
        }
    }

}
