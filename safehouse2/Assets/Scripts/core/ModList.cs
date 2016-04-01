using System.Collections.Generic;
public class ModList : List<Modifier> {
	public bool contains(string modstring) {
		return Contains(new Modifier(modstring));
	}
}
	
