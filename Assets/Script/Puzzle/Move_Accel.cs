using UnityEngine;
using System.Collections;

public class Move_Accel : MonoBehaviour {

    public Rigidbody2D rb;
    Vector2 pos;
    public float MoveSpeed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(Input.acceleration.x * MoveSpeed, -Input.acceleration.z * MoveSpeed);
	}
}
