using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StringInput(string s)
    {
        MainManager.playerName = s;
        Debug.Log("player name is: " + MainManager.playerName);
    }

    //a reference for selecting character type
    //using OnClick event in button inspector
    public void SetToCube()
    {
        MainManager.playerCharacter = 2;
    }
    public void SetToSphere()
    {
        MainManager.playerCharacter = 1;
    }
    public void SetToCapsule()
    {
        MainManager.playerCharacter = 3;
    }
}
