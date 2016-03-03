using System;
using System.Collections.Generic;

class EventSelector {


        public List<Modifier> mods;

        public List<Event> chains;

        public Event generateEvent() {
                /*List<Event> ret = new List<Event>();
                foreach (List<Event> c in chains) {
                        Event e = c.First();
                        if (e == null)
                                continue;
                        if (e.generate(mods)) {
                                e.init(this);
                                ret.add(e);
                        }
                }
                return ret;*/
		return null; //TODO
	}

	public EventSelector () {
		mods = new List<Modifier>();	
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

