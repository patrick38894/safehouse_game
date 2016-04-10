using UnityEngine;
using System.Collections;

public class AgentViewbox : MonoBehaviour {
	public Place selectedLocation;
	public GameObject defaultAgentCard;
	// Use this for initialization
	void Start () {
		//defaultAgentCard = (GameObject)Resources.Load ("AgentCard");
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void setLocation(Place p) {
		foreach (Transform t in transform) {
			Destroy (t.gameObject);
		}
		selectedLocation = p;
		Debug.Log ("set the location to " + selectedLocation.name);

		foreach (Agent a in selectedLocation.agentList) {
			Debug.Log ("agent is here: " + a.name);
			AgentCardScript agentScr = defaultAgentCard.GetComponent<AgentCardScript> ();
			agentScr.setAgent (a);
			GameObject go = (GameObject)Instantiate (defaultAgentCard,Vector3.zero,Quaternion.identity);
			go.transform.SetParent (transform, false);

		}
	}

}
