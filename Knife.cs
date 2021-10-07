using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*this script is attached to the baseball bat on the cowboy character (the baseball bat mesh has been replaced with a knife mesh*/
public class Knife : MonoBehaviour
{   
    //boo for if the player has a knife
    public bool hasKnife = false;
    public GameObject theKnife;
    GameObject player;
    GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        //assign the gameobject with the tag player to the player variable 
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void Update()
    {
        //if the player has knives enable the knife mesh and change the damage to be able to kill a zombie in one hit 
        if(player.GetComponent<KnifeCounter>().numOfKnives > 0)
        {
            theKnife.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<CoverShooter.Melee>().Damage = 1000f;
        }
        
        //if the player has no knives, disable the knife mesh and make it do as much damage as a punch 
        if(player.GetComponent<KnifeCounter>().numOfKnives <= 0)
        {
            this.GetComponent<CoverShooter.Melee>().Damage = 20f;
            theKnife.GetComponent<MeshRenderer>().enabled = false;  
        }
      //if zombe is not null 
      if(zombie != null)
        {   
            //when the zombie dies subtract the total amount of knives from the KnifeCounter by one
            if(zombie.GetComponent<CoverShooter.CharacterHealth>().Health <= 0f)
            {
                player.GetComponent<KnifeCounter>().numOfKnives -= 1;                
                zombie = null;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            zombie = other.gameObject;
        }
    }
}
