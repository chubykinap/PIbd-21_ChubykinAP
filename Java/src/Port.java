import java.util.Dictionary;
import java.util.HashMap;
import java.util.Iterator;

public class Port<T> implements Comparable<Port<T>>, Iterable<T>, Iterator<T> {
	private HashMap<Integer, T> places;
	private int maxCount;
	private T defVal;
	private int curIndex;

	public Port(int size, T defValue) {
		defVal = defValue;
		places = new HashMap<Integer, T>();
		maxCount = size;
	}

	private boolean CheckFreePlaces(int index) {
		if (places.get(index) == null) {
			return true;
		}
		return false;
	}

	public static <T extends ITech> int plus(Port<T> p, T ship)
			throws ParkingOverflowException, ParkingAlreadyHaveException {
		if (p.places.size() == p.maxCount) {
			throw new ParkingOverflowException();
		}
		int index = p.places.size();
		for (int i = 0; i <= p.places.size(); i++) {
			if (p.CheckFreePlaces(i)) {
				index = i;
			}
			if (p.places.get(i) != null
					&& ship.getClass().equals(p.places.get(i).getClass())) {
				if (ship instanceof Cruiser) {
					if (ship.equals(p.places.get(i))) {
						throw new ParkingAlreadyHaveException();
					}
				} else if (ship instanceof Ship) {
					if (ship.equals(p.places.get(i))) {
						throw new ParkingAlreadyHaveException();
					}
				}
			}
		}
		if (index != p.places.size()) {
			p.places.put(index, ship);
			return index;
		}
		p.places.put(p.places.size(), ship);
		return p.places.size() - 1;
	}

	public static <T extends ITech> T minus(Port<T> p, int index)
			throws ParkingIndexOutOfRangeException {
		if (p.places.get(index) != null) {
			T ship = p.places.get(index);
			p.places.remove(index);
			return ship;
		}
		throw new ParkingIndexOutOfRangeException();
	}

	public T getShip(int index) {
		if (places.get(index) != null) {
			return places.get(index);
		} else {
			return defVal;
		}
	}

	@Override
	public Iterator<T> iterator() {
		return this;
	}

	@Override
	public int compareTo(Port<T> other) {
		if (this.size() > other.size()) {
			return -1;
		} else if (this.size() < other.size()) {
			return 1;
		} else {
			Integer[] thisKeys = this.places.keySet().toArray(
					new Integer[this.size()]);
			Integer[] otherKeys = other.places.keySet().toArray(
					new Integer[other.size()]);
			for (int i = 0; i < this.places.size(); ++i) {
				if (this.places.get(thisKeys[i]) instanceof Ship
						&& this.places.get(thisKeys[i]) instanceof Cruiser) {
					return 1;
				}
				if (this.places.get(thisKeys[i]) instanceof Cruiser
						&& this.places.get(thisKeys[i]) instanceof Ship) {
					return -1;
				}
				if (this.places.get(thisKeys[i]) instanceof Cruiser
						&& this.places.get(thisKeys[i]) instanceof Cruiser) {
					return ((Cruiser) this.places.get(thisKeys[i]))
							.compareTo((Cruiser) this.places.get(thisKeys[i]));
				}
				if (this.places.get(thisKeys[i]) instanceof Ship
						&& this.places.get(thisKeys[i]) instanceof Ship) {
					return ((Ship) this.places.get(thisKeys[i]))
							.compareTo((Ship) this.places.get(thisKeys[i]));
				}

			}
		}
		return 0;
	}

	private int size() {
		return places.size();
	}

	@Override
	public boolean hasNext() {
		if (curIndex + 1 >= places.size()) {
			Reset();
			return false;
		}
		curIndex++;
		return true;
	}

	@Override
	public T next() {
		return places.get(curIndex);
	}

	private void Reset() {
		curIndex = -1;
	}
}
