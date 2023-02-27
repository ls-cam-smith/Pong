using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private List<Vector2> startVectors;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        startVectors = new List<Vector2>();
        // Setup 4 diagonal Vectors for initial ball direction
        startVectors.Add(new Vector2(-10f, -10f));
        startVectors.Add(new Vector2(-10f, 10f));
        startVectors.Add(new Vector2(10f, -10f));
        startVectors.Add(new Vector2(10f, 10f));
        Reset();
    }

    private void Reset()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        var random = new System.Random();
        rigidbody.velocity = startVectors[random.Next(startVectors.Count)];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            Reset();
        }
    }
}
