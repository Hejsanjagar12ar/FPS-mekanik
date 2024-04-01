using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADS : MonoBehaviour
{
    public GameObject rifle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            rifle.GetComponent<Animator>().Play("ADS");
        }

        if (Input.GetMouseButtonUp(1))
        {
            rifle.GetComponent<Animator>().Play("New State");
        }
    }
}
