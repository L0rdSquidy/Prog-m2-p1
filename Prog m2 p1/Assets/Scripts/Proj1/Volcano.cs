using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : MonoBehaviour
{
    public GameObject VolcanoPrefab;
    private float elapsedTime = 0f;
    [SerializeField] private List<GameObject> Eruption;
    int destroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                VolcanoErupt();
            }
        }
        if (elapsedTime > 3f)
        {
            for (int i = 0; i < 3; i++)
            {
                VolcanoErupt();
            }
            elapsedTime = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            while (Eruption.Count > 0)
            {
                Destroy(Eruption[0]);
                Eruption.Remove(Eruption[0]);
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(ToDestroy());
        }
    }

    void VolcanoErupt()
    {
        GameObject lava = Instantiate(VolcanoPrefab);
        lava.AddComponent<MoveLava>();
        Eruption.Add(lava);
    }
    private IEnumerator ToDestroy()
    {
        while (Eruption.Count > 0)
        {
            Destroy(Eruption[0]);
            Eruption.Remove(Eruption[0]);
            yield return new WaitForSeconds(0.01f);
        }
    }
}

public class MoveLava : MonoBehaviour
{
    private float extraSpeed = 10;
    private void Update() 
    {
        transform.position += Vector3.forward * extraSpeed * Time.deltaTime;
    }
}
