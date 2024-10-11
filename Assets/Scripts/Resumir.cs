using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resumir : MonoBehaviour
{
    public GameObject Pausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pausa()
    {
        Pausa.SetActive(false);
        Time.timeScale = 1f;
    }
 
}
