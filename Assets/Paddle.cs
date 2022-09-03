using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class Paddle : MonoBehaviour
{
    public PlayerInput input;
    private Rigidbody2D rigidbody;
    private float movementX;
    private float movementY;
    private Vector2 movement;
    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(
            new Vector2(movementX, movementY) * speed
        );
    }

    private void OnMove(InputValue movementValue)
    {
        movement = movementValue.Get<Vector2>();
        movementX = movement.x;
        movementY = movement.y;

    }


}
