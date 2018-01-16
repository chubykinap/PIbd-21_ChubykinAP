import java.util.Dictionary;
import java.util.Hashtable;

public class Port<T> {
	private Dictionary<Integer, T> places;
	private int maxCount;
	private T defVal;

	private boolean CheckFreePlaces(int index) {
		if (places.get(index) == null) {
			return true;
		}
		return false;
	}

	public static <T extends ITech> int plus(Port<T> p, T ship) {
		if (p.places.size() == p.maxCount) {
			return -1;
		}
		for (int i = 0; i <= p.places.size(); i++) {
			if (p.CheckFreePlaces(i)) {
				p.places.put(i, ship);
				return i;
			}
		}
		return -1;
	}

	public static <T extends ITech> T minus(Port<T> p, int index) {
		if (p.places.get(index) != null) {
			T ship = p.places.get(index);
			p.places.remove(index);
			return ship;
		}
		return p.defVal;
	}

	public Port(int size, T defValue) {
		defVal = defValue;
		places = new Hashtable<Integer, T>();
		maxCount = size;
	}

	public T getShip(int index) {
		if (places.get(index) != null) {
			return places.get(index);
		} else {
			return defVal;
		}
	}
}
