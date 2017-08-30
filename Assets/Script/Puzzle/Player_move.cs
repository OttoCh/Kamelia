using UnityEngine;
using System.Collections;

public class Player_move : MonoBehaviour
{
    //Harus diperbaiki lagi agar bisa berjalan diagonal
    public Rigidbody2D rb;
    public Vector2 pos;
    public float MoveSpeed;
    public bool EnableMove;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        MovingPlayer();
    }

    void MovingPlayer()
    {
        if (EnableMove)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(0, 0.7f * MoveSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(-0.7f * MoveSpeed, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(0, -0.7f * MoveSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(0.7f * MoveSpeed, 0);
            }
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
                rb.velocity = new Vector2(0, 0);
        }
        else return;
    }

    
}
