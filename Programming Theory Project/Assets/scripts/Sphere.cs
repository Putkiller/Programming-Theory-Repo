using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class Sphere : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {
        characterForce = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !GameManager.gameOver)
        {
            Jump();
        }
    }

    protected override void Jump()
    {
        base.Jump();
        isGrounded = false;
    }
}
