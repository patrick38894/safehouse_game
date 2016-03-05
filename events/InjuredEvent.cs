using System.Collections.Generic;
class InjuredEvent : Event {
	public string evenType = "agent";
        protected EventSelector target;
        public bool generate(ModList mods) {
		if (mods.contains("agent") && !mods.contains("injured"))
			int n = rand.Next(1,100);	
			

        public void init(EventSelector e){
		target = e;
	}

	public Event next;
	public Event update(){return null;}
	public void process(){}
}

