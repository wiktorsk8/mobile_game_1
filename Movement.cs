using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Settings")]
    [SerializeField] private float mouseSens;
    //[SerializeField] private float multiplier = 0.01f;

    private Vector3 sidewaysMove;

    private float xMove;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    private void Update()
    {
        xMove = Input.GetAxis("Mouse X");
        sidewaysMove = Vector3.right*xMove;
        //MoveSideways();
    }

    private void FixedUpdate()
    {
        MoveSideways();
    }



    private void MoveSideways()
    {
        rb.AddForce(sidewaysMove * mouseSens, ForceMode.Acceleration);
    }
}
