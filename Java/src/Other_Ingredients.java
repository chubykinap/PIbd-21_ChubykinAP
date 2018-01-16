public class Other_Ingredients {
	public boolean exist = true;
	private int ready = 0;
	public boolean has_ready = false;

	public int Ready() {
		return ready;
	}

	public void Heat() {
		if (ready < 15) {
			ready++;
		}
	}
}
