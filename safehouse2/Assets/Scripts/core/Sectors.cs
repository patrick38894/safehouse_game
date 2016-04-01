using System;
using System.Collections.Generic;


public class Sectors : Place
{
	public List<Place> subLocations;

	public Sectors(String name) :
		base(name) {
		
		subLocations = new List<Place>();
		subLocations.Add(new Place("the factory"));
		subLocations.Add(new Place("the dock"));
		subLocations.Add(new Place("the car lot"));
	}

}

