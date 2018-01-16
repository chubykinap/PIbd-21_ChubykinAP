public class Cabbage {
	private int ready = 0;
	public boolean cutted;

	public int Ready() {
		return ready;
	}

	public void Heat() {
		if (ready < 15) {
			ready++;
		}
	}
}
