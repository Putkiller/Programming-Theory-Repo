using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject obstacle;
    [SerializeField]
    Vector3 spawnPos;
    Vector3 spawnPosPlayer;

    float spawnRate = 2.0f;

    [SerializeField] List<GameObject> playerType = new List<GameObject>(3);

    // Start is called before the first frame update
    void Start()
    {
        //spawn player
        spawnPosPlayer = new Vector3(-7.5f, 0.3f, -3.2f);
        Instantiate(playerType[MainManager.playerCharacter-1], spawnPosPlayer, gameObject.transform.rotation);

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
