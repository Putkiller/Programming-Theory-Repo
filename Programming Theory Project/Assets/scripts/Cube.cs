using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : PlayerController
{
    [SerializeField]
    float time = 0f;
    bool heldDownJump = false;

    // Start is called before the first frame update
    void Start()
    {
        characterForce = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        //input space+ check if on ground then jump
        /*
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
        */
        if(Input.GetKey(KeyCode.Space) && time < 0.5f && (isGrounded || heldDownJump))
        {
            time += Time.deltaTime;
            heldDownJump = true;

            Jump();
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            heldDownJump = false;
            time = 0;
        }

    }

    protected override void Jump()
    {
        base.Jump();
        isGrounded = false;
    }
    
}
