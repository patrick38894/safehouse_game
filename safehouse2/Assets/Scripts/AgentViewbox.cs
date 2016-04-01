using UnityEngine;
using System.Collections;

public class AgentViewbox : MonoBehaviour {
	public Place selectedLocation;
	// Use this for initialization
	void Start () {
		LocationsPageScr LS = transform.parent.parent.parent.GetComponent<LocationsPageScr>() as LocationsPageScr;
		selectedLocation = LS.currentLocation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
