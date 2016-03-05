using System.Collections.Generic;
abstract class Event {
        //public eventType eventType;
        protected EventSelector target;
	public string name = "abstract base event";
	public bool completed = false;
        public bool generate(List<Modifier> mods){return false;}

        public void init(EventSelector e){
		target = e;
	}

	public static bool operator ==(Event e1, Event e2) {
		return (e1.target == e2.target && e1.name == e2.name);
	}

	public static bool operator !=(Event e1, Event e2) {
		return !(e1 == e2);
	}
	public Event next;
	public Event update(){return null;}
	public void process(){}
}

