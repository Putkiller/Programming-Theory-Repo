using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    float posMinX = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < posMinX)
        {
            Destroy(gameObject);
        }

        if(!GameManager.gameOver)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        }
    }
}
