using System;
public class StatModifier : Modifier {
        public Stats s;
        public new void display() {
                Console.WriteLine("stat modifier {");
		s.display();
                Console.WriteLine("}");
        }

}

