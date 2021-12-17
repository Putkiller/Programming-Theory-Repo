using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    [SerializeField]
    public static string playerName;

    public static int playerCharacter = 2; //1= sphere, 2= cube, 3 = capsule

    //manages data between scenes
    public static MainManager Instance;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StringInput(string s)
    {
        playerName = s;
        Debug.Log("player name is: " + playerName);
    }

    //a reference for selecting character type
    //using OnClick event in button inspector
    public void SetToCube()
    {
        playerCharacter = 2;
    }
    public void SetToSphere()
    {
        playerCharacter = 1;
    }
    public void SetToCapsule()
    {
        playerCharacter = 3;
    }

}
