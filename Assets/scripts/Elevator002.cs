﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator002 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.y = Mathf.PingPong(Time.time * 6, 25) + 126.69f;
        transform.position = pos;
    }
}
