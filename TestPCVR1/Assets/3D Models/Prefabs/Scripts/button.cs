using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private Transform transform;
    private Vector3 startPosition;
    private Animation animation;
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
        startPosition = transform.position;
        animation = gameObject.GetComponent<Animation>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.collider.tag == "Hand")
        {
            animation.Play();
        }
    }
}