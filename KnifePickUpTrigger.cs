using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifePickUpTrigger : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<PressCUi>().isInTrigger = true;
            if (Input.GetKeyDown(KeyCode.C))
            {
                player.GetComponent<KnifeCounter>().numOfKnives += 1;
                player.GetComponent<PressCUi>().isInTrigger = false;
                this.transform.parent.gameObject.SetActive(false);
            }
        }

    }
}