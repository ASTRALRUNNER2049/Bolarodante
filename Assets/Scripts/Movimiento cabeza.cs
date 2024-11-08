using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientocabeza : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f * Time.deltaTime, 0f * Time.deltaTime, 25f * Time.deltaTime);
    }
}
