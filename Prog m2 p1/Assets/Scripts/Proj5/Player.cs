using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Enemy, IMovable, IDamagable
{
    private float rotationSpeed = 100;

    void Start() 
    {
        speed = 10;
    }
    
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage();
        }
    }
}
