using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject muzzleflash;
    public int ammo;
    // Start is called before the first frame update
    void Start()
    {
        ammo = 15;
        muzzleflash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        #region handles shooting

        if (Input.GetMouseButton(0) && ammo > 0) 
        {
            ammo -= 1;
        }

        if (Input.GetMouseButton(0) && ammo > 0)
        {
            muzzleflash.SetActive(true);
        }
        
        #endregion
    }
}
