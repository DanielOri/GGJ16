using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpForce;

    bool isGround;
    public Transform checkerOrigin;
    public float checkerRadius;
    public LayerMask whatIsGround;

    Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    void Update () {
        if (Input.GetButtonDown("Jump") && isGround) {
            rb2d.velocity = new Vector2 (rb2d.velocity.x, jumpForce);

        }
    }

	void FixedUpdate () {
        rb2d.velocity = new Vector2 (speed * Input.GetAxisRaw("Horizontal"), rb2d.velocity.y);
        isGround = Physics2D.OverlapCircle (checkerOrigin.position, checkerRadius, whatIsGround);
    }
}
