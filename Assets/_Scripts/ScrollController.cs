﻿using UnityEngine;
using System.Collections;

public class ScrollController : MonoBehaviour {
	// Public Instance Value.
	public float ScrollSpeed = 0.5f;

	// Private Instance Value.
	private float TargetOffset;
	private Vector2 OffSetV2;

	// Update is called once per frame
	void Update () {
		// Moving BG Scroll
		this.TargetOffset = Mathf.Repeat (Time.time * this.ScrollSpeed, 1);
		OffSetV2 = new Vector2 (this.TargetOffset, 0);
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", this.OffSetV2 );
		//this.TargetOffset += Time.deltaTime * this.ScrollSpeed;
		//GetComponent<Renderer>().sharedMaterial.SetTextureOffset = new Vector2 (this.TargetOffset, 0);
	
	}
}
