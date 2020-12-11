﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{
	public float speed;
	public float angle;
	public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        angle = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
    	if (Mathf.Round(transform.eulerAngles.y) != angle){
    		//rotate our door
    		transform.Rotate(direction * speed);
    	}    
    	if (Input.GetKeyDown(KeyCode.O) && angle != 90){
    		angle = 90;
    		direction = Vector3.up; //0 1 0
    	}
    	if (Input.GetKeyDown(KeyCode.C) && angle != 0){
    		angle = 0;
    		direction = -Vector3.up;
    	}
    }
}
