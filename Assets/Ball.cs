using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new private Rigidbody2D rigidbody2D;
    private TrailRenderer trailRenderer;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        trailRenderer = GetComponent<TrailRenderer>();
        Reset();
    }

    private void FixedUpdate()
    {
        var velocity = rigidbody2D.velocity;
        if (velocity.magnitude < 0.1f)
        {
            rigidbody2D.AddForce(new Vector2(0.1f, 0.1f));
        }
        else if (velocity.magnitude > 50.0f)
        {
            Reset();
        }
    }

    private void Reset()
    {
        Debug.Log(trailRenderer);
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        var speedY = Random.Range(-3.0f, 3.0f);
        var isLeftFacing = Random.Range(0, 1);
        var speedX = isLeftFacing == 1 ? -10.0f : 10.0f;

        rigidbody2D.velocity = new Vector2(-10.0f, speedY);
        trailRenderer.Clear();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            Reset();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var shoveVector = rigidbody2D.velocity * new Vector2(1.2f, 1.3f);
            rigidbody2D.velocity = shoveVector;
        }
    }
}
