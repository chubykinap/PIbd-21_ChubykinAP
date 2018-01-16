public class Port<T> {
	private T[] places;
	private T defVal;

	private int GetCountPlaces() {
		return places.length;
	}

	private boolean CheckFreePlaces(int index) {
		if (index < 0 || index > places.length) {
			return false;
		}
		if (places[index] == null) {
			return true;
		}
		return false;
	}

	private void AddShip(int index, T ship) {
		places[index] = ship;
	}

	public static <T extends ITech> int plus(Port<T> p, T ship) {
		for (int i = 0; i < p.GetCountPlaces(); i++) {
			if (p.CheckFreePlaces(i)) {
				p.AddShip(i, ship);
				return i;
			}
		}
		return -1;
	}

	public static <T extends ITech> T minus(Port<T> p, int index) {
		if (!p.CheckFreePlaces(index)) {
			T ship = p.places[index];
			p.places[index] = p.defVal;
			return ship;
		}
		return p.defVal;
	}

	public Port(int size, T defValue) {
		defVal = defValue;
		places = (T[]) new ITech[size];
		for (int i = 0; i < places.length; i++) {
			places[i] = defVal;
		}
	}

	public T getShip(int index) {
		if (index > -1 && index < GetCountPlaces()) {
			return places[index];
		} else {
			return defVal;
		}
	}
}
