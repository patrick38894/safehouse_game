using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LocationsPageScr : MonoBehaviour {
	
	//public List<Place> places = new List<Place>();
	public Agency parentAgency = null;

	// Use this for initialization
	void Start () {
		parentAgency = transform.parent.GetComponent<Agency> () as Agency;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
