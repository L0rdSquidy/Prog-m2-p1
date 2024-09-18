using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ImAPlane : MonoBehaviour
{
    public GameObject Plane;
    private float elapsedTime = 0f;
    private void CreateBall(Color c)
    {

        GameObject ball = Instantiate(Plane);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0f,1f);
        float g = Random.Range(0f,1f);
        float b = Random.Range(0f,1f);
        Color randColor = new Color(r,g,b,1f);

        elapsedTime += Time.deltaTime;
        if(elapsedTime > 1f){
            CreateBall(randColor);
            elapsedTime = 0f;
        }
    }
}
