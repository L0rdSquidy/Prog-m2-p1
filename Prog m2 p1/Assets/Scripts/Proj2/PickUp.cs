using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public static event Action OnPickUp;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            OnPickUp?.Invoke();
            Destroy(gameObject);
        }
    }
}
