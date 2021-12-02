using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : PlayerController
{
    int jumpCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        characterForce = 4;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    protected override void Jump()
    {
        base.Jump();

        //can jump twice in the air
        jumpCount += 1;
        if(jumpCount > 1)
        {
            isGrounded = false;
            jumpCount = 0;
        }
    }
}
