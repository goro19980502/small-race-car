﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_1 : MonoBehaviour {


    // Use this for initialization
    void Start () {
        
	}
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, -1);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, 1);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 1, 0);
        }
	}
}
