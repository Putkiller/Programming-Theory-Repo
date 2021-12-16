using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject obstacle;
    [SerializeField]
    Vector3 spawnPos;

    float spawnRate = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //spawn player


        //spawn obstacles
        spawnPos = new Vector3(22, 0.28f, -3f);
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.gameOver)
        {
            StopCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        while(!GameManager.gameOver)
        {
            //spawn objects at random interval
            Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
            yield return new WaitForSeconds(spawnRate);
        }
        
        
    }
}
