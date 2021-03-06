using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField]
    protected Rigidbody playerRb;
    [SerializeField]
    protected float characterForce;
    [SerializeField]
    protected bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    //ABSTRACTION
    protected virtual void Jump()
    {
        playerRb.AddForce(new Vector3(0, 1, 0)*characterForce, ForceMode.Impulse);
        
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Ground>())
        {
            isGrounded = true;
        } else if ( collision.gameObject.GetComponent<MoveLeft>() != null)
        {
            GameManager.gameOver = true;
        }
    }
}
