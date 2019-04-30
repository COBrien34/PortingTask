using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SantaControlScript : MonoBehaviour {
    float dirX;

    public float moveSpeed = 5f, jumpForce = 700f;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        dirX = CrossPlatformInputManager.GetAxis("Horizontal");

        if (CrossPlatformInputManager.GetButtonDown("Jump")) 
            DoJump();
		
	}

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    public void DoJump()
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
    }
}
