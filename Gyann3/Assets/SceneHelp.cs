﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class SceneHelp : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("koi");
            SceneManager.LoadScene("GameHelp2");//シーン切替

        }

    }
}
