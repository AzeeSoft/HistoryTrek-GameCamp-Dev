using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour {

	public string holding;
	public List<GameObject> InventoryObjs = new List<GameObject> ();
	public GameObject InventoryObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (holding != "") {
			foreach (GameObject obj in InventoryObjs) {
				if (obj.name == holding) {
					obj.SetActive (true);
					InventoryObj = obj;
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Artifact" && holding == "") {
			holding = other.gameObject.name;
			Destroy (other.gameObject);
		}

		if (other.tag == "Dropoff" && holding != "") {
			if (other.gameObject.GetComponent<DropoffObjects> ().acceptedObj == holding) {
				holding = "";
				other.gameObject.GetComponent<DropoffObjects> ().Obj.SetActive (true);
				InventoryObj.SetActive (false);
				//Update GameManager Script to Change Score
			}
		}
	}
}
