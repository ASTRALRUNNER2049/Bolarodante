using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformasvolantes : MonoBehaviour
{

    public Transform [] target;
    float speed = 3.0f;

    int curPos = 0;
    int nextPos = 1;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards (transform.position, target[nextPos].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target[nextPos].position) <= 0)
        {
            curPos = nextPos;
            nextPos++;

            if(nextPos == target.Length - 1) 
                nextPos = 0;
           

        }
    }
}
