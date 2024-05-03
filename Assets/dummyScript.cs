using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyScript : MonoBehaviour
{
    public GameObject dummy;

    // Start is called before the first frame update
    void Start()
    {
        dummy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage() 
    {
        dummy.SetActive(false);
        Invoke("dummyRespawn", 10f);
    }

    void dummyRespawn() 
    {
        dummy.SetActive(true);
    }

}
