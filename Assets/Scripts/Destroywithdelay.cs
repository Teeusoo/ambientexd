﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroywithdelay : MonoBehaviour {

	public float delay = 3f;

	void Start () {
		Destroy(gameObject, delay);
	}				
}
