using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoCounter : MonoBehaviour
{
    int maxLoadedAmmo = 3;
    public int loadedAmmo;
    int toBeLoaded;
    public int ammoInventory;

    public GameObject pistol;

    // Start is called before the first frame update
    void Start()
    {
      // pistol = GameObject.FindGameObjectWithTag("PlayerPistol");
    }

    // Update is called once per frame
    void Update()
    {
        pistol.GetComponent<CoverShooter.Gun>().LoadedBullets = loadedAmmo;

        if(pistol == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                loadedAmmo -= 1;
            }
        }

        if(loadedAmmo < 0)
        {
            loadedAmmo = 0;
        }

        //if (Input.GetKey(KeyCode.R))
        //{
        //    //pistol.GetComponent<CoverShooter.Gun>().LoadedBullets = ammoInventory - loadedAmmo;
        //    if(ammoInventory < loadedAmmo && loadedAmmo >=maxLoadedAmmo)
        //    {
        //        toBeLoaded = ammoInventory - loadedAmmo;
        //        pistol.GetComponent<CoverShooter.Gun>().LoadedBullets += toBeLoaded;
        //    }


        //}
    }
}
