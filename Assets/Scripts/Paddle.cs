using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 1;

    private KeyCode upBinding;
    private KeyCode downBinding;
    private new Rigidbody2D rigidbody;
    private float movementY;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        if (isPlayer1)
        {
            upBinding = KeyCode.W;
            downBinding = KeyCode.S;
        } else
        {
            upBinding = KeyCode.UpArrow;
            downBinding = KeyCode.DownArrow;
        }
    }

    private void Update()
    {
        if (Input.GetKey(upBinding))
        {
            movementY = 1.0f;
        }

        if (Input.GetKey(downBinding))
        {
            movementY = -1.0f;
        }
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(
            new Vector2(0.0f, movementY) * speed
        );
        // a kind of logarithmic falloff, maybe the new input system can handle this for me?
        movementY = movementY / 4.0f;
    }


}
