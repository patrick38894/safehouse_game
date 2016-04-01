using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LocationsPageScr : MonoBehaviour {
	
	//public List<Place> places = new List<Place>();
	public Agency parentAgency = null;
	public Place currentLocation;
	// Use this for initialization
	void Start () {
		parentAgency = transform.parent.GetComponent<Agency> () as Agency;
		//TODO change to be dynamic
		currentLocation = parentAgency.field.subLocations[0];
	}


	// Update is called once per frame
	void Update () {
	
	}
}
