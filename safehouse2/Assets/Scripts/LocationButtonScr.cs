using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LocationButtonScr : MonoBehaviour {
	public Place location;
	public AgentViewbox vb;
	// Use this for initialization
	public void setInfo (Place p, AgentViewbox window) {
		vb = window;
		location = p;
		//TODO code for grabbing pngs etc
	}

	void Start () {
		Button b = GetComponent<Button>();
		b.onClick.AddListener(() => vb.setLocation(location));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
