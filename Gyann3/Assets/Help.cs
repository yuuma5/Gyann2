using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour {

    public Canvas page = null;
    public Canvas page2 = null;

	// Use this for initialization
	void Start () {
        if (page != null)
        {
            page.enabled = true;
        }
        if (page2 != null)
        {
            page2.enabled = false;
        }
	}

    public void Keydown()
    {
        if (page != null)
        {
            page.enabled = false;
        }
        if (page2 != null)
        {
            page2.enabled = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Keydown();
        }
	}
}
