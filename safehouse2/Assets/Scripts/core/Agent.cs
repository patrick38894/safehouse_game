using System.Collections.Generic;
using System;
public class Agent : EventSelector {
        public Stats agentStats;
	public string name;
	
	public void display() {
		Console.WriteLine("Agent: " + name + "{");
		agentStats.display();
		Console.WriteLine();
		Console.WriteLine("modifiers: {");
		foreach (Modifier m in mods)
			m.display();
		Console.WriteLine("}");
		Console.WriteLine("}");
		Console.WriteLine();
	}

        void changeStats(Stats s){}
        int genIntel(Place whereami){return 0;}

	public Agent() { //generate a random agent
		Random rnd = new Random();
		int idx = rnd.Next(0,8);
		string [] names = {"bob", "jon", "ben", "sue", "alice", "patty", "russle", "mat"};
		name = names[idx];
		agentStats = new Stats(rnd.Next(1,20) + rnd.Next(1,20), rnd.Next(1,20) + rnd.Next(1,20), rnd.Next(1,20) + rnd.Next(1,20), rnd.Next(1,20) + rnd.Next(1,20), 2);
		chains.Add(new InjuredEvent());
		mods.Add(new Modifier("agent"));
	}

	public Agent(string n, List<Modifier> mods, Stats s) {
		name = n;
		foreach (Modifier m in mods) {
			mods.Add(m);
		}
		agentStats = s;
	}

	public Agent(string n,  Stats s) {
		name = n;
		agentStats = s;
	}
	
	public new void update(){
		base.update();
	}
}

