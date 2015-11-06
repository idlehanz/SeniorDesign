﻿using UnityEngine;
using System.Collections;

public class PowerlineProperties : MonoBehaviour {

	public float frequency = 60f;//hertz, HAS TO BE 60!
	public float current;
	public float lineImpedance = 34.5f;
	public float voltage = 80f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		current = voltage / lineImpedance; 
	}
}