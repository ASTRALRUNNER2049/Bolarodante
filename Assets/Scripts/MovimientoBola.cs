using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody bolaRigidbody;
    public Respawn Respawn;

    public float verticalVelocity;
    public float horizontalVelocity;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            bolaRigidbody.AddTorque(0, 0, -verticalVelocity);
        }

        if (Input.GetKey(KeyCode.S))
        {
            bolaRigidbody.AddTorque(0, 0, verticalVelocity);
        }

        if (Input.GetKey(KeyCode.A))
        {
            bolaRigidbody.AddTorque(horizontalVelocity, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            bolaRigidbody.AddTorque(-horizontalVelocity, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Muerte")
        {
            Destroy(gameObject);
            Respawn.MuerteBola();
        }


    }
}
