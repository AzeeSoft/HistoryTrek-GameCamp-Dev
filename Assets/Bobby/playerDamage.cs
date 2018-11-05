using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour {

	 playerManager PM;

	// Use this for initialization
	void Start () {

	    PM = GetComponent<playerManager>();
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKeyUp (KeyCode.F)) {
		
			Manager.Lives -= 1;
			spawn.Respawn ();
		
			Debug.Log (Manager.Lives);
		
		}*/


	}

    void LoseLife()
    {
        PM.Lives -= 1;
        spawn.Respawn();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Lightning")
        {
            LoseLife();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "KillZone")
        {
            LoseLife();
        }
    }

}
