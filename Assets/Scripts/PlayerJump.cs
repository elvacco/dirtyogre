using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;

    [SerializeField] int jumpPower;
    [SerializeField] float fallMultiplier;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    Vector2 vecGravity;

    // Start is called before the first frame update
    void Start()
    {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(2f,0.4f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if(isGrounded && (Input.GetButtonDown("Jump") 
    || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        if(rb.velocity.y < 0)
        {
            rb.velocity -= vecGravity * fallMultiplier * Time.deltaTime;
        }
    }
}
