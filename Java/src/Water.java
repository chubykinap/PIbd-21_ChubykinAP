public class Water {
	private int temperature = 0;
	public int Temperature;

	public void Heat() {
		if (temperature < 100) {
			temperature++;
		}
	}
}
