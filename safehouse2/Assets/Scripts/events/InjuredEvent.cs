using System.Collections.Generic;
using System;
class InjuredEvent : Event {
        override public bool generate(ModList mods) {
		int n = 0;
		if (mods.contains("agent") && !mods.contains("injured"))
			n = rnd.Next(1,100);	

		Console.WriteLine("Generating injured event");
		if (n > 90)
			return true;
		else	
			//return false;
			return true; //for testing
	}
			
	public InjuredEvent () {
		name = "injured event";
		next = null;
	}

	override public Event update(){return null;}
	
	override public void process(){
	//	Console.WriteLine("inside of the injured event");
	}
}

