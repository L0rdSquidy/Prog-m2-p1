using System.Collections;
using UnityEngine;

public class ShootFromCamera : MonoBehaviour
{
    public GameObject projectilePrefab; //vergeet geen prefab in te slepen via de inspector
    private Plane floor;
    int Shootnumber;
    void Start()
    {
        floor = new Plane(Vector3.up, 0);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Shootnumber = 1;
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shootnumber = 100;
            StartCoroutine(Shooting());
        }

    }

    private IEnumerator Shooting()
    {
        for (int i = 0; i < Shootnumber; i++)
        {
            float dist;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (floor.Raycast(ray, out dist)) {
                GameObject p = Instantiate(projectilePrefab, transform.position, transform.rotation);
                Vector3 tPos = ray.GetPoint(dist);
                p.transform.LookAt(tPos);
                p.AddComponent<MoveProj>();
                Destroy(p,5f);
            }
            if (Input.GetKey(KeyCode.X)) 
            {
                break;
            } else
            {
               yield return new WaitForSeconds(0.1f); 
            }
            
                
        }
            
    }
}

public class MoveProj : MonoBehaviour
{
    private float moveSpeed = 20f;
    private void Start() 
    {
        gameObject.transform.tag = "Bullet";
    }
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

}
