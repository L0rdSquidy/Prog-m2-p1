using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ImAPlane : MonoBehaviour
{
    public GameObject Plane;
    private float elapsedTime = 0f;
     private GameObject CreateBall(Color c){
        

        GameObject ball = Instantiate(Plane, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-10f, 10f),  UnityEngine.Random.Range(-10f, 10f)), Quaternion.identity);
        Destroy(ball, 3f);
        Material material = ball.GetComponent<MeshRenderer>().material;

        // voor CORE pipeline

        //Voor URP
        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);
        }

        return ball;

    }
    private void RandomReset()
    {
    float r = Random.Range(0f,1f);
    float g = Random.Range(0f,1f);
    float b = Random.Range(0f,1f);
    Color randColor = new Color(r,g,b,1f);
    CreateBall(randColor);
    }
    // Start is called before the first frame update
    void Start()
    {
       BallChoas();
    }

    public void BallChoas()
    {
         for (int i = 0; i < 100; i++)
        {
            RandomReset();
            
        }
    }
    

    // Update is called once per frame
    void Update()
    {      
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 1f){
            RandomReset();
            elapsedTime = 0f;
        }
    }
}
