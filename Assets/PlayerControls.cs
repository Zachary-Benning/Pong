using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    // This is what the game calls every frame or in some cases
    // every time the game is called to check the 'game state'
    void Update()
    {
        var local_velocity = body2D.velocity;

        if (Input.GetKey(escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(moveUp))
        {
            local_velocity.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            local_velocity.y = -speed;
        }
        else if (!Input.anyKey)
        {
            local_velocity.y = 0;
        }

        body2D.velocity = local_velocity;
        var position = transform.position;
        if (position.y > YBoundary)
        {
            position.y = YBoundary;
        }
        else if (position.y < -YBoundary)
        {
            position.y = -YBoundary;
        }

        transform.position = position;
    }
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode escape = KeyCode.Escape;
    public float speed = 8.25f;
    public float YBoundary = 3.14f;
    private Rigidbody2D body2D;
}