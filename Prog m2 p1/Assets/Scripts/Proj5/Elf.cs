using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Enemy
{
    private float timeelapsed;
    private bool IsActive = false;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        health = 3;
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        MoveON();
        timeelapsed += Time.deltaTime;
        if (timeelapsed > 0.5)
        {
            renderer.enabled = true;
            IsActive = false;
        }
        if (!IsActive)
        {
        if (timeelapsed > 3)
            {
                renderer.enabled = false;
                timeelapsed = 0;
                IsActive = true;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Healthcheck();
        }
    }

}
