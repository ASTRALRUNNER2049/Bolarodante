using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody bolaRigidbody;
    public Respawn Respawn;
    public int vidas = 100;
    public int monedas = 0;
    public Rigidbody rb;
    public float fuerzasalto = 8f;
    public bool Salto;

    public float verticalVelocity;
    public float horizontalVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Salto = false;
        vidas = 3;
        monedas = 0;    
    }
    private void FixedUpdate()
    {
        

    }

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
            
            vidas--;
            Respawn.MuerteBola();
            Debug.Log("Has Muerto, tienes -1 Vida");
           
            if (vidas == 0)
            {
              Destroy(gameObject);
            }


        }



        if (collision.gameObject.tag == "Moneda")
        {
            monedas++;
            Debug.Log("Has cogido 1 moneda");
        }


    }
}
