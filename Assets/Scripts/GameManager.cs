using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {

    public string redText;

	// Use this for initialization
	void Start () {

        //Set text
        GameObject moveTextGameObj = GameObject.Find("MoveText");
        Instance.redText = moveTextGameObj.GetComponent<Text>().text;

    }

    // Update is called once per frame
    void Update () {
		
	}


    public void LoadNextLevel()
    {

        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);

    }
}
