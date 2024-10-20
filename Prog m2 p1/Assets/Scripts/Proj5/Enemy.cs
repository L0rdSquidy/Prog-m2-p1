using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int speed;
    [SerializeField] GameObject PointB;

    // Update is called once per frame
    void Update()
    {
       MoveON();
    }

    public void MoveON()
    {
        transform.position = Vector3.MoveTowards(transform.position, PointB.transform.position, speed * Time.deltaTime);
    }
    

    public void Healthcheck()
    {
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
