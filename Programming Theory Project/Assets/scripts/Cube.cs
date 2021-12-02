using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : PlayerController
{
    [SerializeField]
    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        characterForce = 10;
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
        if(Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
        }

    }

    protected override void Jump()
    {
        base.Jump();
        isGrounded = false;
    }
    
}
