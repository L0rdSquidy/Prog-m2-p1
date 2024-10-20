using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Enemy
{
    void Start()
    {
        health = 15;
        speed = 1;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Healthcheck();
        }
    }
}
