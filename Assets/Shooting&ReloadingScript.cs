using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ShootScript : MonoBehaviour
{
    public GameObject muzzleflash;
    public GameObject magazine;
    public int ammo;
    bool reloading;
    public Transform bulletSpawnPoint;
    [SerializeField] private AudioSource shootingSound;
    [SerializeField] private AudioSource reloadingSound;
    [SerializeField] private AudioSource emptyChamber;
    [SerializeField]
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        ammo = 15;

        reloading = false;
        
        muzzleflash.SetActive(false);

        magazine.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        #region handles shooting

        if (Input.GetMouseButtonDown(0) && ammo > 0 && reloading == false)
        {
            GameObject bulletGameObject = Instantiate(bullet, bulletSpawnPoint.position + transform.forward, Quaternion.identity);

            bulletGameObject.transform.LookAt(bulletSpawnPoint.position + transform.forward * 2);

            shootingSound.Play();

            ammo -= 1;

            muzzleflash.SetActive(true);
            
            Invoke("disableFlash", 0.05f);
        }

        if (Input.GetMouseButtonDown(0) && ammo == 0 && reloading == false)
        {
            emptyChamber.Play();
        }

        #endregion

        #region handles reloading

        if (Input.GetKeyDown(KeyCode.R) && reloading == false)
        {
            reloadingSound.Play();

            reloading = true;
            
            magazine.SetActive(false);
            
            Invoke("reloadMagazine", 3f);
        }

        #endregion
    }

    void disableFlash() 
    {
        muzzleflash.SetActive(false);
    }

    void reloadMagazine() 
    {
        magazine.SetActive(true);

        ammo = 15;

        reloading = false;
    }
}
