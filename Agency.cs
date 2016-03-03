using System;
using System.Collections.Generic;

class Agency {
        protected List<Place> places;
        protected List<Event> currentEvents;

        public Agency() {
                places = new List<Place>();
                places.Add(new Place("field"));
                places.Add(new Place("office"));
                places.Add(new Place("research"));
                places.Add(new Place("onCall"));

                currentEvents = new List<Event>();
        }


        public void turn () {
                generateEvents();
                processEvents();
                updateAll();
                //displayStatus();
        }


        public void updateAll() {
		List<Event> nextEvents = new List<Event>();
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
                        Event e = p.generateEvent();
                        if (e != null)
                                currentEvents.Add(e);
                        foreach (Agent a in p.agentList) {
                                e = a.generateEvent();
                                if (e != null)
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
		while (true) {
			agency.display();
			agency.turn();
			Console.ReadLine();
		}
		
	}
}

