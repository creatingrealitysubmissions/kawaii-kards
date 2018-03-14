using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System.IO;

public class CatChoice : MonoBehaviour {

	public GameObject Cat, Bear, Rabbit;
	// Use this for initialization
	void Start () {
		Cat = GameObject.Find ("Right_Cat");
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButtonDown (0)) {
//			Debug.Log ("Clicking");
//			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//			RaycastHit hit;
//
//			if(Physics.Raycast(ray, out hit)){
//				
//				Debug.Log(" you clicked on " + hit.collider.gameObject.name);
//				if(hit.collider.gameObject.name == "Right_Cat"){
//					Debug.Log("Correct");
//				} else if(hit.collider.tag == "Bear" || hit.collider.tag == "Rabbit"){
//					Debug.Log("Wrong");
//				}
//			
//			}
//		}
			
	}
}
