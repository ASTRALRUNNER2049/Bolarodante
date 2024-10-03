using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform PosRespawn;
    public Transform PosPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuerteBola()
    {
        PosPlayer.position = PosRespawn.position;
    }
}
