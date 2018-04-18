using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class gameTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("誕生日おめでとう曜ちゃん");
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("koi");
            SceneManager.LoadScene("GameHelp");//シーン切替

        }

    }
}
