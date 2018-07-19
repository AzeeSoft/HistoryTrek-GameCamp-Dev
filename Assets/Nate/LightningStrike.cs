using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStrike : MonoBehaviour {

	public ParticleSystem ps;
	public GameObject LightningCollider;
	public BoxCollider2D Trigger;

	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem> ();
		Trigger = LightningCollider.GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ps.particleCount >= 1) {
			Trigger.enabled = true;
		} else {
			Trigger.enabled = false;
		}
	}
}
