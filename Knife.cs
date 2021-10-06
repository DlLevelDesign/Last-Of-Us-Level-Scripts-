using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this script is attached to the baseball bat on the cowboy character 
public class Knife : MonoBehaviour
{
    public bool hasKnife = false;

    public GameObject theKnife;
    GameObject player;
    GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<KnifeCounter>().numOfKnives > 0)
        {
           theKnife.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<CoverShooter.Melee>().Damage = 1000f;
        }

        if(player.GetComponent<KnifeCounter>().numOfKnives <= 0)
        {
            this.GetComponent<CoverShooter.Melee>().Damage = 20f;
            theKnife.GetComponent<MeshRenderer>().enabled = false;
            
        }

      if(zombie != null)
        {
            if(zombie.GetComponent<CoverShooter.CharacterHealth>().Health <= 0f)
            {
                player.GetComponent<KnifeCounter>().numOfKnives -= 1;
                zombie.gameObject.tag = "Untagged";
                //this will eathier eliminate bugs or cause them 
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

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "Enemy")
    //    {
    //        zombie = null;
    //    }
    //}

}
