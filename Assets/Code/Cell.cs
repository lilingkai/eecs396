﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

    public Transform _transform;
	// Use this for initialization
	void Start () {
        _transform = GetComponent<Transform>();
	}

    private void OnMouseDown()
    {
        print(_transform.position.x);
        FindObjectOfType<BuildMenu>().appear((int)_transform.position.x, (int)_transform.position.z);
    }
    //public void makeTower()
    //{
    //    FindObjectOfType<Grid>().newTower((int)GetComponent<Transform>().position.x, (int)GetComponent<Transform>().position.z);
    //}

    // Update is called once per frame
    void Update () {
		
	}
}
