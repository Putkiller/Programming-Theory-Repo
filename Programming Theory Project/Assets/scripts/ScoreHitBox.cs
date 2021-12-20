using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHitBox : MonoBehaviour
{
    [SerializeField] GameObject gameManager;
    GameManager gameManagerSpt;

    [SerializeField]
    int score;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerSpt = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.GetComponent<MoveLeft>());
        //for some reason can't get component. need to fix this as the info is gonna be useful for future projects.
        //Rigidbody is not a Collider class type. So need to add Box Collider to obstacle for it to work. Rigidbody is a Collision class type so it works with OnCollisionEnter.
        if (other.gameObject.GetComponent<MoveLeft>() != null)
        {
            gameManagerSpt.UpdateScore();
            score += 1;
        }
    }
}
