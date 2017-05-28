using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2 : Singleton<Scene2> {

	// Use this for initialization
	void Start () {
        
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetTextFromInstance()
    {
        string redTextFromSceneOne = GameManager.Instance.redText;
        GameObject.Find("TextToChange").GetComponent<Text>().text = redTextFromSceneOne;
    }
}
