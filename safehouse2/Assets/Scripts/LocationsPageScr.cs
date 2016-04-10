using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class LocationsPageScr : MonoBehaviour {
	
	//public List<Place> places = new List<Place>();
	public Agency parentAgency = null;
	public Place currentLocation;
	public GameObject defaultLocationButton;
	// Use this for initialization
	void Start () {
		parentAgency = transform.parent.GetComponent<Agency> () as Agency;

		Vector2 xgap = new Vector2 (128 + 16, 0 );
		Vector2 ygap = new Vector2(0, 128 + 16);
		int n_buttons = 0;
		foreach (Place p in parentAgency.field.subLocations) {
			//build button prefab

			//customize button here
			//go.AddComponent<LocationButtonScr>();
			//go.transform.SetParent (transform, false);
			//LocationButtonScr sc = go.GetComponent<LocationButtonScr> ();
			Vector2 pos = new Vector2 (0, 0);
			pos += xgap * (n_buttons % 4);
			pos -= ygap * (n_buttons / 4);
			//attach script
			GameObject go = (GameObject) Instantiate(defaultLocationButton,pos,Quaternion.identity);
			LocationButtonScr lbs = go.GetComponent<LocationButtonScr> ();
			lbs.setInfo (p, transform.GetChild (0).transform.GetChild (0).GetComponent<AgentViewbox> ());
			go.transform.SetParent (transform, false);
			++ n_buttons;
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
