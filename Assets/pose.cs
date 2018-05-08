using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pose : MonoBehaviour {
    public GameObject phose;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // @harley: Prefer to use Input bindings via the InputManager rather
        //          than using KeyCodes.
        if (Input.GetKeyDown(KeyCode.End))
        {
            phose.SetActive(true);
           
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            phose.SetActive(false);
        }
    }
}
