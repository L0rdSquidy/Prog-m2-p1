using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDWalker : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical"));

        characterController.Move(move * speed * Time.deltaTime);
    }
}
