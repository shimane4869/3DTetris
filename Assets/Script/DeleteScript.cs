﻿using UnityEngine;
using System.Collections;

public class DeleteScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
