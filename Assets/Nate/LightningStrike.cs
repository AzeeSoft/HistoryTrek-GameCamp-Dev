using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStrike : MonoBehaviour {

	public ParticleSystem ps;
	public GameObject LightningCollider;
	public BoxCollider2D Trigger;

    public float triggerEnableDelay = 1f;

    private bool triggerEnablePending = false;

	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem> ();
		Trigger = LightningCollider.GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ps.particleCount >= 1)
		{
		    if (!Trigger.enabled)
		    {
		        StartCoroutine(WaitAndEnableTrigger());
		    }
		} else {
			Trigger.enabled = false;
		}
	}

    IEnumerator WaitAndEnableTrigger()
    {
        if (triggerEnablePending)
        {
            yield return null;
        }

        triggerEnablePending = true;
        yield return new WaitForSeconds(triggerEnableDelay);
        triggerEnablePending = false;

        Trigger.enabled = true;
    }
}
