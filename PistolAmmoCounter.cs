using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*track the amount of pistol ammo the player has*/
public class PistolAmmoCounter : MonoBehaviour
{   
    
    int maxLoadedAmmo = 3;
    public int loadedAmmo;
    int toBeLoaded;
    public int ammoInventory;

    public GameObject pistol;

    // Update is called once per frame
    void Update()
    {   
        //communicates with the Gun script that the LoadedBullets var from that script will equal the loadedAmmo var in this script 
        pistol.GetComponent<CoverShooter.Gun>().LoadedBullets = loadedAmmo;
        
        //if the pistol is active and the player fires it then subtract one bullet from the ammo count 
        if(pistol == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                loadedAmmo -= 1;
            }
        }
        
        //if the loaded ammo count is below zero set it to 0
        if(loadedAmmo < 0)
        {
            loadedAmmo = 0;
        }
    }
}
