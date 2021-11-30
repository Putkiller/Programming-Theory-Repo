using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
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

    public virtual void Jump()
    {
        playerRb.AddForce(new Vector3(0, 1, 0)*characterForce, ForceMode.Impulse);
        isGrounded = false;
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Ground>())
        {
            isGrounded = true;
        }
    }
}
