using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{

    private Transform transform;
    private Animation animation;
    private AudioSource audioSource;
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
        animation = gameObject.GetComponent<Animation>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Hand")
        {
            audioSource.PlayOneShot(audioSource.clip);

            animation.Play();
        }
    }
}
