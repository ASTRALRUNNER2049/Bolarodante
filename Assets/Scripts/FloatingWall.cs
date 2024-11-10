using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingWall : MonoBehaviour
{
    private Rigidbody rb;
    private Collider col;
    private void Start()
    {
        col = GetComponent<Collider>();

        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.relativeVelocity.magnitude > 1)
        {
            rb.AddForce(new Vector3(
                Random.Range(-1f, 1f),
                Random.Range(0.5f, 1.5f),
                Random.Range(-1f, 1f)) * 5, ForceMode.Impulse);
            col.enabled = false;

            rb.useGravity = false;
        }
    }
}
