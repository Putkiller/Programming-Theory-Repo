using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : PlayerController
{
    [SerializeField]
    float time = 0f;
    bool heldDownJump = false;
    float timeHeldDownJump = 0.5f;

    float jumpHeight = 5f;

    // Start is called before the first frame update
    void Start()
    {
        characterForce = 25f;
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
        if(Input.GetKey(KeyCode.Space) && time < timeHeldDownJump && (isGrounded || heldDownJump))
        {
            time += Time.deltaTime;
            heldDownJump = true;

            Jump();
        }

        if(Input.GetKeyUp(KeyCode.Space) || time > timeHeldDownJump)
        {
            heldDownJump = false;
            time = 0;
            StartFall();
        }

    }

    protected override void Jump()
    {
        characterForce = CalculateJumpForce();

        playerRb.AddForce(new Vector3(0, 1, 0) * characterForce * Time.deltaTime, ForceMode.VelocityChange);
        isGrounded = false;
    }

    void StartFall()
    {
        playerRb.AddForce(new Vector3(0, 0, 0) * characterForce, ForceMode.VelocityChange);
    }

    
    float CalculateJumpForce()
    {
        float jumpForce = 0f;
        // h = v^2/(2g)
        // v = sqrt(h* 2g)
        jumpForce = Mathf.Sqrt(jumpHeight * 2 * Physics.gravity.magnitude);

        return jumpForce;
    }
    
    
}
