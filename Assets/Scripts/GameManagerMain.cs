using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MovimientoBola MovimientoBola;
    public int vidas = 3;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;

        if (vidas == 0) 
        {
            Destroy(MovimientoBola);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
