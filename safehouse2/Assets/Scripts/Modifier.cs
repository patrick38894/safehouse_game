using System;

class Modifier {
        public string name;
	public Modifier (string n) {
		name = n;
	}

	public Modifier () {
		name = "default modifier";
	}

	public void display() {
		Console.WriteLine("modifier {");
		Console.WriteLine(name);
		Console.WriteLine("}");
	}
}

