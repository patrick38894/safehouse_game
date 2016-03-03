using System.Collections.Generic;
abstract class Event {
        //public eventType eventType;
        public EventSelector target;
        public bool generate(List<Modifier> mods){return false;}
        public void init(EventSelector e){}
	public Event next;
	public Event update(){return null;}
	public void process(){}
}

