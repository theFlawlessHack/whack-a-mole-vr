﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown("space")) {
            
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit)) {
                if (hit.transform.GetComponent<Mole>() != null) {
                    Mole mole = hit.transform.GetComponent<Mole>();
                    mole.OnHit();

                    score++;
                }
            }
        }
	}
}
