using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : MonoBehaviour
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
        audioSource.PlayOneShot(SocialCredit);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(15f * Time.deltaTime, 30f * Time.deltaTime, 0f * Time.deltaTime);
    }
}
