using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Enemy, IMovable, IDamagable
{
    private float timeelapsed;
    private bool IsActive = false;
    private Renderer enderer;
    public int Health
    {
        get { return health; }
    }

    // Start is called before the first frame update
    void Start()
    {
        enderer = GetComponent<Renderer>();
        health = 3;
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        timeelapsed += Time.deltaTime;
        if (timeelapsed > 0.5)
        {
            enderer.enabled = true;
            IsActive = false;
        }
        if (!IsActive)
        {
        if (timeelapsed > 3)
            {
                enderer.enabled = false;
                timeelapsed = 0;
                IsActive = true;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage();
        }
    }

}
