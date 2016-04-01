using UnityEngine;
using System;
using System.Collections.Generic;

public class Agency : MonoBehaviour {
    protected List<Place> places;
    protected HashSet<Event> currentEvents;
	public Sectors field;
	public Place office;
	public Place research;
	public Place onCall;

        public Agency() {
                places = new List<Place>();
                field = new Sectors("field");
                office = new Place("office");
                research = new Place("research");
                onCall = new Place("onCall");
                places.Add(field);
                places.Add(office);
                places.Add(research);
                places.Add(onCall);

                currentEvents = new HashSet<Event>();
        }


        public void turn () {
                generateEvents();
                processEvents();
                updateAll();
                //displayStatus();
        }


        public void updateAll() {
		HashSet<Event> nextEvents = new HashSet<Event>();
                foreach (Event e in currentEvents) {
                        Event x = e.update();
			if (x != null)
				nextEvents.Add(x);
		}
		currentEvents = nextEvents;
                foreach (Place p in places) {
                        p.update();
                        foreach (Agent a in p.agentList)
                                a.update();
                }
        }

	public void processEvents() {
		foreach (Event e in currentEvents) {
			e.process();
		}

	}



        public void generateEvents() {
                foreach (Place p in places) {
                        List<Event> es = p.generateEvents();
                        if (es != null)
				foreach (Event e in es)
                                	currentEvents.Add(e);
                       	foreach (Agent a in p.agentList) {
                                es = a.generateEvents();
                                if (es != null)
					foreach (Event e in es)
						currentEvents.Add(e);
                        }
                }
        }

	public void display() {
		foreach (Place p in places)
			p.display();
	}
	
	static void Main (string [] args) {
		Agency agency = new Agency();
		Agent x = new Agent();
		Agent y = new Agent();
		Agent z = new Agent();
		agency.onCall.addAgent(x);	
		agency.onCall.addAgent(y);	
		agency.onCall.addAgent(z);	
		while (true) {
			agency.display();
			foreach (Agent a in agency.onCall.agentList) {
				agency.field.agentList.Add(a);
			}
			foreach (Agent a in agency.field.agentList) {
				agency.onCall.agentList.Remove(a);
			}
			
			agency.turn();
			Console.ReadLine();
		}
		
	}
}

