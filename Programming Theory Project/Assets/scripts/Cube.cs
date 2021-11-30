using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : PlayerController
{
    [SerializeField]
    bool isGrounded = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input space+ check if on ground then jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    public override void Jump()
    {
        base.Jump();
    }
}
