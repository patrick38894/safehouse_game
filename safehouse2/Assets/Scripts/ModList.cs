using System.Collections.Generic;
class ModList : List<Modifier> {
	public bool contains(string modstring) {
		return Contains(new Modifier(modstring));
	}
}
	
