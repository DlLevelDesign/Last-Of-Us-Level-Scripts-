using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        dialogue = GameObject.Find("QuicklyThisWayText");
        dialogue.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cargo.GetComponent<BoxCollider>().enabled = false;
            plank.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //cargo.GetComponent<BoxCollider>().enabled = false;
            headlight.SetActive(true);
            headlight1.SetActive(true);
            
            
            foreach(GameObject railing in railings)
            {
                railing.SetActive(false);
            }

            this.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine(waiter());

        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        gate.transform.Rotate(gate.transform.rotation.x, gate.transform.rotation.y + 90f, gate.transform.rotation.z);
        horde.SetActive(true);
        middleCamera.SetActive(true);
        yield return new WaitForSeconds(2);
        middleCamera.SetActive(false);
        sidecamera.SetActive(true);
        dialogue.GetComponent<Text>().text = "Quickly, This Way!";
        cargo.GetComponent<BoxCollider>().enabled = true;
        yield return new WaitForSeconds(3);
        dialogue.GetComponent<Text>().text = "";
        sidecamera.SetActive(false);
        this.enabled = false;
    }

}
