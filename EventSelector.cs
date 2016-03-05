using System;
using System.Collections.Generic;

class EventSelector {


        public ModList mods;

        public List<Event> chains;

        public List<Event> generateEvents() {
		Console.WriteLine("generating events");
                List<Event> ret = new List<Event>();
                foreach (Event e in chains) {
                        if (e.generate(mods)) {
                                e.init(this);
                                ret.Add(e);
                        }
                }
                return ret;
	}
	
	public void update() {
		List<Event> newChains = new List<Event>();
		foreach (Event e in chains) {
			if (e.completed) {
				if (e.next != null)
					newChains.Add(e.next);
			}
			else
			newChains.Add(e);
		}
		chains = newChains;
	}

	public EventSelector () {
		mods = new ModList();	
		chains  = new List<Event>();	
	}

	public void addModifier(Modifier m) {
		mods.Add(m);
	}

        public void removeModifier(string name) {
		Modifier mt = null;
		foreach (Modifier m in mods) //dafuq is this for loops are forced to have variable declarations?
			if (m.name == name) {
				mt = m; //fuck c# for making me do this
				break;
			}
		if (mt != null)
			mods.Remove(mt);
	}
}

