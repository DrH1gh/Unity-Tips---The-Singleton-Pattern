using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {

    public string redText;

	void Start () {

        GameObject moveTextGameObj = GameObject.Find("MoveText");
        Instance.redText = moveTextGameObj.GetComponent<Text>().text;

    }

    public void LoadNextLevel()
    {

        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);

    }
}
