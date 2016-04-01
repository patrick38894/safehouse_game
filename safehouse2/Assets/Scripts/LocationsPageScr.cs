using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LocationsPageScr : MonoBehaviour {
	
	//public List<Place> places = new List<Place>();
	public Agency parentAgency = null;
	public Place currentLocation;
	public GameObject defaultLocationButton;
	// Use this for initialization
	void Start () {
		parentAgency = transform.parent.GetComponent<Agency> () as Agency;
		foreach (Place p in parentAgency.field.subLocations) {
			//build button prefab
			GameObject go = new GameObject("SectorField");
			go.AddComponent<LocationButtonScr>();
			LocationButtonScr sc = go.GetComponent<LocationButtonScr> ();
			sc.location = p;
			//attach script
			Instantiate(go);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
