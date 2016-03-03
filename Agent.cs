using System.Collections.Generic;
using System;
class Agent : EventSelector {
        public List<Modifier> agentMods;
        public Stats agentStats;
	public string name;
	
	public void display() {
		Console.WriteLine("Agent: " + name + "{");
		agentStats.display();
		Console.WriteLine();
		Console.WriteLine("modifiers: {");
		foreach (Modifier m in agentMods)
			m.display();
		Console.WriteLine("}");
		Console.WriteLine("}");
		Console.WriteLine();
	}

        void changeStats(Stats s){}
        int genIntel(Place whereami){return 0;}

	public Agent(string name, List<Modifier> mods, Stats s) {
		name = name;
		agentMods = new List<Modifier>();
		foreach (Modifier m in mods) {
			agentMods.Add(m);
		}
		agentStats = s;
	}

	public Agent(string name,  Stats s) {
		agentMods = new List<Modifier>();
		name = name;
		agentStats = s;
	}
	
	public void update(){}
}

