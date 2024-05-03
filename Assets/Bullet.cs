using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody myRigidbody;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        myRigidbody.velocity = transform.forward * 50;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;

        dummyScript hitEnemy = otherGameObject.GetComponent<dummyScript>();

        if(hitEnemy != null) 
        {
            hitEnemy.TakeDamage();
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("despawnBullet", 5f); 
    }

    void despawnBullet() 
    {
        Destroy(gameObject);
    }
}
