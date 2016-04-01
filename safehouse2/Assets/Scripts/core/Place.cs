using System.Collections.Generic;
using System;
public class Place : EventSelector {
    public List<Agent> agentList;
	public string name;

        public void addAgent(Agent a) {
		agentList.Add(a);
	}

        public Agent removeAgent(int idx) { 
		Agent a = agentList[idx];
		agentList.RemoveAt(idx);
		return a;
	}

        public Agent removeAgent(string name) {
		Agent a = null;
		foreach (Agent aa in agentList)
			if (a.name == name)
				break;
		if (a != null)
			agentList.Remove(a);
		return a;
	}
	
        public Agent getAgent(string name) {
		Agent a = null;
		foreach (Agent aa in agentList)
			if (a.name == name)
				break;
		return a;
	}

        public Agent getAgent(int idx) {
		return agentList[idx];
	}

	public Place (string n) {
		agentList = new List<Agent>();
		name = n;
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
	
	public new void update(){
		base.update();
	}
}

