using UnityEngine;
using System.Collections;

public class LocationButtonScr : MonoBehaviour {
	public Place location;
	public AgentViewbox vb;
	// Use this for initialization
	public LocationButtonScr (Place p, AgentViewbox window) {
		vb = window;
		location = p;
		//TODO code for grabbing pngs etc
	}

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick() {
		vb.selectedLocation = location;
	}
}
