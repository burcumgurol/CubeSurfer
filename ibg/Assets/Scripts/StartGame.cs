using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    GameObject startButton;
    GameObject gameTitle;
    GameObject mainCube;
    private void Start()
    {
        gameTitle = GameObject.Find("GameName");
        startButton = GameObject.Find("StartBtn");
        mainCube = GameObject.Find("MainCube");
    }
    public void Starter()
    {
        if(SceneManager.GetActiveScene().name == "Scene1")
        {
            gameTitle.SetActive(false);
        }
        startButton.SetActive(false);
        mainCube.GetComponent<PlayerMovement>().enabled = true;
    }
}
