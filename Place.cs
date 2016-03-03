using System.Collections.Generic;
using System;
class Place : EventSelector {
        public List<Agent> agentList;
	public string name;

        void addAgent(Agent a) {
		agentList.Add(a);
	}

        Agent removeAgent(int idx) { 
		Agent a = agentList[idx];
		agentList.RemoveAt(idx);
		return a;
	}

        Agent removeAgent(string name) {
		Agent a = null;
		foreach (Agent aa in agentList)
			if (a.name == name)
				break;
		if (a != null)
			agentList.Remove(a);
		return a;
	}
	
        Agent getAgent(string name) {
		Agent a = null;
		foreach (Agent aa in agentList)
			if (a.name == name)
				break;
		return a;
	}

        Agent getAgent(int idx) {
		return agentList[idx];
	}

	public Place (string name) {
		agentList = new List<Agent>();
		name = name;
	}
	
	public void display() {
		Console.WriteLine("place {");
		Console.WriteLine("name: " + name);
		Console.WriteLine("agents at this location: {");
		foreach (Agent a in agentList)
			a.display();
		Console.WriteLine("}");
		Console.WriteLine();
	}
	
	public void update(){}
}

