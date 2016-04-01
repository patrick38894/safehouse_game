using System.Collections.Generic;
using System;
public abstract class Event {
        //public eventType eventType;
	public static Random rnd = new Random();
        protected EventSelector target;
	public string name = "abstract base event";
	public bool completed = false;
        abstract public bool generate(ModList mods);

        public void init(EventSelector e){
		target = e;
	}
	/*
	public override bool Equals(System.Object obj) {
		if (obj == null)
			return false;
		Event e = obj as Event;
		if ((System.Object) e == null)
			return false;
		return e.name == name; //compare by name only
	}
	*/
	public Event next;
	abstract public Event update();
	abstract public void process();
}

