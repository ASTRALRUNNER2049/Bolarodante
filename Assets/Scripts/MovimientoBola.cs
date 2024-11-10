using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MovimientoBola : MonoBehaviour
{
    public GameObject Player;
    public GameObject Ganaste;
    public GameObject Perdiste;
   
    public Rigidbody bolaRigidbody;
    public Respawn Respawn;
   
    public int vidas = 100;
    public Rigidbody rb;
    public float fuerzasalto = 8f;
    public float verticalVelocity;
    public float horizontalVelocity;

    private RaycastHit _raycastHit;
    private int _inAir;

    public float longitudRaycast;
    public LayerMask raycastLayerMask;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        vidas = 3;

      
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
        Salto();
        //if (!isGrounded)
        //{
        //    if (Salto = Input.GetKeyDown(KeyCode.E))
        //    {
        //        rb.AddForce(new Vector3(0,fuerzasalto, 0), ForceMode.Impulse);
        //    }
        //}
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
              Time.timeScale = 0;
              Perdiste.SetActive(true);
              
            }
        }

        if (collision.gameObject.tag == "Meta")
        {
            Time.timeScale = 0;
            Ganaste.SetActive(true);
        }

    }

    private void Salto()
    {
        Physics.Raycast(transform.position, Vector3.down, out _raycastHit, longitudRaycast, raycastLayerMask);

        if (_raycastHit.collider != null)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_inAir == 2)
                {
                    _inAir = 0;
                }

                if (_inAir == 0)
                {
                    GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzasalto, 0), ForceMode.Impulse);
                    _inAir = 1;
                }
            }
            else
            {
                _inAir = 2;
            }
        }
    }




}
