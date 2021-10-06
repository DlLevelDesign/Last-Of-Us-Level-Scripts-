using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTriggerSpawner : MonoBehaviour
{

    public GameObject[] zombies;


    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject zombie in zombies)
        {
            zombie.SetActive(false);
        }

        this.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
