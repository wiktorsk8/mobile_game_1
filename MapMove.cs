using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float multiplier;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed*multiplier)*Time.deltaTime;
    }
}
