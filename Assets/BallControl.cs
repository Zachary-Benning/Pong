using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D body2D;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            body2D.AddForce(new Vector2(20, -15));
        }
        else
        {
            body2D.AddForce(new Vector2(-20, -15));
        }
    }

    void ResetBall()
    {
        body2D.velocity = new Vector2(0, 0);
        transform.position = Vector2.zero;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Vector2 local_velocity;
            local_velocity.x = body2D.velocity.x;
            local_velocity.y = (body2D.velocity.y / 1.8f) + (collision.collider.attachedRigidbody.velocity.y / 2.0f);
            body2D.velocity = local_velocity;
        }
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }
}
