﻿using UnityEngine;
using System.Collections;

public class Echo : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        Destroy(gameObject, 4f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
