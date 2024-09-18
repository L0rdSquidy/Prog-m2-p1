using System;
using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using TreeEditor;
using Unity.Mathematics;
using UnityEngine;

public class Class : MonoBehaviour
{
    Vector3 randScale;
    // Start is called before the first frame update
    public GameObject Tower;    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         randScale=new Vector3(UnityEngine.Random.Range(1.0f, 2.0f), UnityEngine.Random.Range(1.0f, 2.0f), UnityEngine.Random.Range(1.0f, 2.0f));
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Tower.transform.localScale = randScale;
            Instantiate(Tower, new Vector3(UnityEngine.Random.Range(-20f, 20f),0, UnityEngine.Random.Range(-20f, 20f)), Quaternion.identity);
        }
    }
}
