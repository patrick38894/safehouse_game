using System;
public class Stats {
        public int charisma = 0;
        public int instinct = 0;
        public int intelligence = 0;
        public int constitution = 0;
        public int health = 2;

        public Stats (int c = 0, int ins = 0, int intl = 0, int cons = 0, int hp = 0) {
                charisma = c;
                instinct = ins;
                intelligence = intl;
                constitution = cons;
                health = hp;
        }
	
        public Stats combine(Stats s) {
                return new Stats(charisma + s.charisma, instinct + s.instinct, intelligence + s.intelligence,
                        constitution + s.constitution, health + s.health);
        }

	public void display() {
		Console.WriteLine("stats: {");
		Console.WriteLine("charisma " + charisma);
		Console.WriteLine("instinct " + instinct);
		Console.WriteLine("intelligence " + intelligence);
		Console.WriteLine("constitution " + constitution);
		Console.WriteLine("health " + health);
		Console.WriteLine();
	}
}

