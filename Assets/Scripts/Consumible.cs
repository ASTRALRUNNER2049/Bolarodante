using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : MonoBehaviour
{
    [SerializeField] private float CantidadSocialcredit;
    [SerializeField] private SocialCredit socialcredit;
   
    [SerializeField] AudioClip SocialCredit;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        socialcredit.SumarSocialCredit(CantidadSocialcredit);
        ControladorSonido.Instance.EjecutarSonido(SocialCredit);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(15f * Time.deltaTime, 30f * Time.deltaTime, 0f * Time.deltaTime);
    }
}
