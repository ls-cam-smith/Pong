using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Reset();
    }

    private void FixedUpdate()
    {
        var velocity = rigidbody.velocity;
        if (velocity.magnitude < 0.1f)
        {
            rigidbody.AddForce(new Vector2(0.1f, 0.1f));
        }
        else if (velocity.magnitude > 5.0f)
        {

        }
    }

    private void Reset()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        var speedY = Random.Range(-3.0f, 3.0f);

        rigidbody.velocity = new Vector2(-10.0f, speedY);
        // rigidbody.angularVelocity = 0.0f;
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
            var shoveVector = rigidbody.velocity * new Vector2(1.2f, 1.3f);
            rigidbody.velocity = shoveVector;
        }
    }
}
