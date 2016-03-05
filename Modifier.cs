using System;

class Modifier {
        public string name;
	public Modifier (string n) {
		name = n;
	}
	public Modifier () {
		name = "default modifier";
	}
	public static bool operator == (Modifier m1, Modifier m2) {
		return m1.name == m2.name;
	}
	public static bool operator != (Modifier m1, Modifier m2) {
		return !(m1.name == m2.name);
	}
	public void display() {
		Console.WriteLine("modifier {");
		Console.WriteLine(name);
		Console.WriteLine("}");
	}
}

