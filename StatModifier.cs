using System;
class StatModifier : Modifier {
        public Stats s;
        public void display() {
                Console.WriteLine("stat modifier {");
		s.display();
                Console.WriteLine("}");
        }

}

