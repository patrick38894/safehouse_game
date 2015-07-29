static enum type {AGENT, FIELD, OFFICE, RESEARCH, ONCALL};

class EventSelector {
	public List<Modifier> mods;

	public List<List<Event>> chains;
	
	public List<Event> generate() {
		List<Event> ret = new List<Event>();
		for (List<Event> c in chains) {
			Event e = c.First();
			if (e == null)
				continue;
			if (e.generate(mods)) {
				e.init(this);
				ret.add(e);
			}
		}
		return ret;
	}
	
}

class Modifier {
	public String name;
	public Stats s;
}

class Stats {
	public int charisma = 0;
	public int instinct = 0;
	public int intelligence = 0;
	public int constitution = 0;
	public int health = 2;

	public Stats (int c = 0, int ins = 0, int intl = 0, int cons = 0, int hp = 0) {
		charisma = c;
		instinct = ins;
		intelligence = intl;
		constitution = cons;
		health = hp;
	}
	
	public Stats combine(Stats s) {
		return new Stats(charisma + s.charisma, instinct + s.instinct, intelligence + s.intelligence,
			constitution + s.constitution, health + s.health);
	}
}

class Agent : EventSelector {
	public Stats s;
}


}

class Place : EventSelector {
	public List<Agent> agentList;

}

abstract class Event {
	public type eventType;
	public EventSelector target;
	public bool generate(List<Modifier>);
	public void init(EventSelector);
}



class Agency {

	protected List<Place> places;
	protected List<Event> currentEvents;

	public Agency {
		places = new List<Place>();
		places.add(new Place("field"));
		places.add(new Place("office"));
		places.add(new Place("research"));
		places.add(new Place("onCall"));

		currentEvents = new List<Event>();
	}


	public void turn {
		generateEvents();
		processEvents();
		updateAll();
		displayStatus();
	}


	public void updateAll() {
		for (Event e in currentEvents)
			e.update();
		for (Place p in places) {
			p.update();
			for (Agent a in p.agentList)
				a.update()
		}
	}



	public void generateEvents() {
		for (Place p in places) {
			Event e = p.eTable.generate(p);
			if (e != null)
				currentEvents.add(e);
			for (Agent a in p.agentList) {
				e = a.eTable.generate(a);
				if (e != null)
					currentEvents.add(e);
			}
		}
	}
}



		
