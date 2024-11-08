using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectodeSonido : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] AudioClip SocialCredit;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(SocialCredit);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
