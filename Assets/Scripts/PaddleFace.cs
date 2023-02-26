using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PaddleFace : MonoBehaviour
{
    public float xDirection;
    public float yDirection;
    public float speed = 1;

    private Vector2 exitDirection;

    public void Start()
    {
        exitDirection = new Vector2(
            xDirection * speed,
            yDirection * speed
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            Debug.Log("MEEP MEEP!");
            collision.attachedRigidbody.velocity = exitDirection;
        }
    }
}
