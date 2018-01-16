public class WaterTap {
	public boolean State;

	public Water GetWater() {
		if (State) {
			return new Water();
		} else {
			return null;
		}
	}
}
